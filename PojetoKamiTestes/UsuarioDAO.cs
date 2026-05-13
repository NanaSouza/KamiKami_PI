using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PojetoKamiTestes
{
    internal class UsuarioDAO
    {
        private string connectionString = "Server=localhost;Database=SistemaLogin;Uid=root;Pwd=sua_senha;";

        // Método para registrar usuário
        public bool RegistrarUsuario(Usuarios usuario)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = @"INSERT INTO Usuarios (NomeCompleto, Cpf, Email, SenhaHash, 
                            TipoUsuario, Telefone, DataNascimento, Status) 
                            VALUES (@Nome, @Cpf, @Email, @SenhaHash, @Tipo, @Telefone, 
                            @DataNasc, @Status)";

                usuario.SenhaHash = HashSenha(usuario.SenhaHash);
                usuario.Status = "Ativo";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", usuario.Nome);
                    cmd.Parameters.AddWithValue("@Cpf", LimparCpf(usuario.Cpf));
                    cmd.Parameters.AddWithValue("@Email", usuario.Email);
                    cmd.Parameters.AddWithValue("@SenhaHash", usuario.SenhaHash);
                    cmd.Parameters.AddWithValue("@Tipo", usuario.TipoUsuario);
                    cmd.Parameters.AddWithValue("@Status", usuario.Status);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Método de autenticação
        public Usuarios Autenticar(string cpf, string senha, string ip)
        {
            cpf = LimparCpf(cpf);

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM Usuarios WHERE Cpf = @Cpf";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Cpf", cpf);
                    conn.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var usuario = new Usuarios
                            {
                                Id = reader.GetInt32("Id"),
                                Nome = reader.GetString("NomeCompleto"),
                                Cpf = reader.GetString("Cpf"),
                                Email = reader.GetString("Email"),
                                SenhaHash = reader.GetString("SenhaHash"),
                                TipoUsuario = reader.GetString("TipoUsuario"),
                                Status = reader.GetString("Status"),
                                TentativasLogin = reader.GetInt32("TentativasLogin"),
                                //DataBloqueio = reader.IsDBNull("DataBloqueio") ?
                                    //null : reader.GetDateTime("DataBloqueio")
                            };

                            // Verificar se usuário está bloqueado
                            if (usuario.Status == "Bloqueado")
                            {
                                RegistrarLog(usuario.Id, ip, "Bloqueado");
                                throw new Exception("Usuário bloqueado. Contate o administrador.");
                            }

                            // Verificar senha
                            if (VerificarSenha(senha, usuario.SenhaHash))
                            {
                                // Resetar tentativas e atualizar último acesso
                                ResetarTentativasLogin(usuario.Id);
                                AtualizarUltimoAcesso(usuario.Id);
                                RegistrarLog(usuario.Id, ip, "Sucesso");
                                return usuario;
                            }
                            else
                            {
                                // Incrementar tentativas de login
                                IncrementarTentativasLogin(usuario.Id);
                                RegistrarLog(usuario.Id, ip, "Falha");

                                // Verificar se deve bloquear (após 5 tentativas)
                                if (usuario.TentativasLogin + 1 >= 5)
                                {
                                    BloquearUsuario(usuario.Id);
                                    throw new Exception("Usuário bloqueado por excesso de tentativas.");
                                }

                                throw new Exception("Senha incorreta.");
                            }
                        }
                        else
                        {
                            RegistrarLog(null, ip, "Falha");
                            throw new Exception("CPF não encontrado.");
                        }
                    }
                }
            }
        }

        // Método para gerar token de recuperação de senha
        public string GerarTokenRecuperacao(string cpf, string email)
        {
            cpf = LimparCpf(cpf);

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT Id FROM Usuarios WHERE Cpf = @Cpf AND Email = @Email AND Status = 'Ativo'";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Cpf", cpf);
                    cmd.Parameters.AddWithValue("@Email", email);
                    conn.Open();

                    var id = cmd.ExecuteScalar();
                    if (id != null)
                    {
                        string token = GerarTokenUnico();
                        DateTime expiracao = DateTime.Now.AddHours(24);

                        string updateQuery = "UPDATE Usuarios SET ResetToken = @Token, ResetTokenExpiracao = @Expiracao WHERE Id = @Id";
                        using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn))
                        {
                            updateCmd.Parameters.AddWithValue("@Token", token);
                            updateCmd.Parameters.AddWithValue("@Expiracao", expiracao);
                            updateCmd.Parameters.AddWithValue("@Id", id);
                            updateCmd.ExecuteNonQuery();
                        }

                        return token;
                    }
                    else
                    {
                        throw new Exception("CPF e Email não correspondem a um usuário ativo.");
                    }
                }
            }
        }

        // Método para redefinir senha
        public bool RedefinirSenha(string token, string novaSenha)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT Id FROM Usuarios WHERE ResetToken = @Token AND ResetTokenExpiracao > @Agora AND Status = 'Ativo'";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Token", token);
                    cmd.Parameters.AddWithValue("@Agora", DateTime.Now);
                    conn.Open();

                    var id = cmd.ExecuteScalar();
                    if (id != null)
                    {
                        string updateQuery = "UPDATE Usuarios SET SenhaHash = @SenhaHash, ResetToken = NULL, ResetTokenExpiracao = NULL WHERE Id = @Id";
                        using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn))
                        {
                            updateCmd.Parameters.AddWithValue("@SenhaHash", HashSenha(novaSenha));
                            updateCmd.Parameters.AddWithValue("@Id", id);
                            return updateCmd.ExecuteNonQuery() > 0;
                        }
                    }
                    else
                    {
                        throw new Exception("Token inválido ou expirado.");
                    }
                }
            }
        }

        // Métodos auxiliares
        private string HashSenha(string senha)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(senha);
                byte[] hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }

        private bool VerificarSenha(string senha, string hash)
        {
            return HashSenha(senha) == hash;
        }

        private string LimparCpf(string cpf)
        {
            return new string(cpf.Where(char.IsDigit).ToArray());
        }

        private string GerarTokenUnico()
        {
            return Convert.ToBase64String(Guid.NewGuid().ToByteArray())
                .Replace("/", "_").Replace("+", "-").Substring(0, 32);
        }

        private void RegistrarLog(int? usuarioId, string ip, string status)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO LogsAcesso (UsuarioId, Ip, Status) VALUES (@UsuarioId, @Ip, @Status)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UsuarioId", usuarioId.HasValue ? usuarioId.Value : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Ip", ip);
                    cmd.Parameters.AddWithValue("@Status", status);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void IncrementarTentativasLogin(int usuarioId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "UPDATE Usuarios SET TentativasLogin = TentativasLogin + 1 WHERE Id = @Id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", usuarioId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void ResetarTentativasLogin(int usuarioId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "UPDATE Usuarios SET TentativasLogin = 0 WHERE Id = @Id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", usuarioId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void BloquearUsuario(int usuarioId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "UPDATE Usuarios SET Status = 'Bloqueado', DataBloqueio = @Data WHERE Id = @Id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Data", DateTime.Now);
                    cmd.Parameters.AddWithValue("@Id", usuarioId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void AtualizarUltimoAcesso(int usuarioId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "UPDATE Usuarios SET UltimoAcesso = @Data WHERE Id = @Id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Data", DateTime.Now);
                    cmd.Parameters.AddWithValue("@Id", usuarioId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PojetoKamiTestes
{
    public class Funcionarios
    {
        public string Nome { get; set; }
        public int Nascimento { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }

    public class PedidoFinanceiro
    {
        public string Numero { get; set; }
        public Dictionary<string, (double preco, int quantidade)> Itens { get; set; }
        public double Total { get; set; }
        public DateTime DataHora { get; set; }
        public string FormaPagamento { get; set; }
    }

    public class Produto
    {
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
    }

    public class Usuarios
    {
        public int Id { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string SenhaHash { get; set; }
        public string TipoUsuario { get; set; }
        public string Ativo { get; set; }  
        public string Tentativaslogin { get; set; }
        public string BloqueioAte { get; set; }
        public string UltimoAcesso { get; set; }
        public string TokenReset { get; set; }
        public string TokenExpira { get; set; }
        public string CriadoEm { get; set; }
        public string Status { get; set; }
        public int TentativasLogin { get; set; }  = 0;
    }
    public class LoginModel
    {
        public string Cpf { get; set; }
        public string Senha { get; set; }
        public bool LembrarMe { get; set; }
    }
    public class EsqueciSenhaModel
    {
        public string Cpf { get; set; }
        public string Email { get; set; }
    }
    public class RedefinirSenhaModel
    {
        public string Token { get; set; }                
        public string NovaSenha { get; set; }                
        public string ConfirmarSenha { get; set; }
    }
}

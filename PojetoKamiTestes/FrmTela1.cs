using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PojetoKamiTestes
{
    public partial class Frm_principal : Form
    {
        string kamikami = "server=localhost;uid=root;password=;database=kamikami;";
        public Frm_principal()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string cpf = msk_usuario.Text
            .Replace(".", "")
            .Replace("-", "")
            .Trim();
            string senha = txt_senha.Text;

            if (string.IsNullOrWhiteSpace(cpf) ||
                string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Preencha CPF e Senha!");
                return;
            }
            MySqlConnection conn = new MySqlConnection(kamikami);
            string sql = "SELECT cpf FROM usuario WHERE cpf = @cpf AND senha = @senha";

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@senha", senha);
                var reader = cmd.ExecuteReader();
                if (reader.GetValue(0) == null)
                {
                    MessageBox.Show("CPF ou senha inválidos.");
                    return;
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}

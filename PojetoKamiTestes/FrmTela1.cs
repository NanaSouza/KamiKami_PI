using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PojetoKamiTestes
{
    public partial class Frm_principal : Form
    {
        public Frm_principal()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e) //NÃO É IMPORTANTE PARA A TELA
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
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

                var usuario = GerenFunc.funcionarios.FirstOrDefault(f =>
                    f.CPF == cpf &&
                    f.Senha == senha);

                if (usuario != null)
                {
                    CriarPedido tela = new CriarPedido();
                    tela.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("CPF ou senha inválidos.");
                }
            }
        }

        private void btn_criarPedido_Click(object sender, EventArgs e) //NÃO É IMPORTANTE PARA A TELA
        {

        }

        private void btn_funcionarios_Click(object sender, EventArgs e) //NÃO É IMPORTANTE PARA A TELA
        {


        }

        private void Frm_principal_Load(object sender, EventArgs e)
        {

        }

        private void btn_novaSenha_Click(object sender, EventArgs e) //Botão que vai redirecionar p/ tela de redefinir senha;
        {

        }
    }
}

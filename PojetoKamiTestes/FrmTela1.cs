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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            CriarPedido tela = new CriarPedido();
            tela.ShowDialog();
        }

        private void btn_criarPedido_Click(object sender, EventArgs e)
        {

        }

        private void btn_funcionarios_Click(object sender, EventArgs e)
        {
            GerenciamentoFuncionarios tela = new GerenciamentoFuncionarios();
            tela.ShowDialog();
        }

        private void Frm_principal_Load(object sender, EventArgs e)
        {

        }
    }
}

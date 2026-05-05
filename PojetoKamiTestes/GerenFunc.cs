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
    public partial class GerenFunc : Form
    {
        public GerenFunc()
        {
            InitializeComponent();
        }

        private void btn_criarPedido_Click(object sender, EventArgs e)
        {
            {
                CriarPedido tela = new CriarPedido();
                tela.ShowDialog();
            }
        }

        private void btn_pedidoAndto_Click(object sender, EventArgs e)
        {
            {
                Financeiro tela = new Financeiro();
                tela.ShowDialog();
            }
        }

        private void btn_financeiro_Click(object sender, EventArgs e)
        {
            {
                Financeiro tela = new Financeiro();
                tela.ShowDialog();
            }
        }

        private void btn_estoque_Click(object sender, EventArgs e)
        {
            {
                Estoque tela = new Estoque();
                tela.ShowDialog();
            }
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                Application.Exit();
            }
        }

        private void btn_funcionarios_Click(object sender, EventArgs e)
        {
            GerenFunc tela = new GerenFunc();
            tela.ShowDialog();
        }
    }
}

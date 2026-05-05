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
    public partial class Financeiro : Form
    {
        public static Financeiro Instancia;

        public Financeiro()
        {
            InitializeComponent();
            Instancia = this;
        }

        private void Financeiro_Load_1 (object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void AdicionarPedidoFinanceiro(PedidoFinanceiro pedido)
        {
            string pagamento = pedido.FormaPagamento;

            // Se vier vazio ou nulo
            if (string.IsNullOrWhiteSpace(pagamento))
            {
                pagamento = "Pix";
            }

            // Se vier algo inválido
            if (pagamento != "Pix" &&
                pagamento != "Dinheiro" &&
                pagamento != "Cartão Débito" &&
                pagamento != "Cartão Crédito")
            {
                pagamento = "Pix";
            }

            dataGridView1.Rows.Add(
                pedido.DataHora.ToString("dd/MM/yyyy HH:mm"),
                pedido.Numero,
                pedido.Total.ToString("F2"),
                pagamento
            );
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Financeiro_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(
          DateTime.Now.ToString("dd/MM/yyyy HH:mm"),
           "0002",
          "50,00",
          "Dinheiro"
    );
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Selecione uma linha.");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.ReadOnly = false;
                dataGridView1.BeginEdit(true);

                MessageBox.Show("Agora clique na célula que deseja editar e altere o valor.");
            }
            else
            {
                MessageBox.Show("Selecione uma linha para editar.");
            }
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
                Pedidoandamento tela = new Pedidoandamento();
                tela.Show();
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            {
                GerenFunc tela = new GerenFunc();
                tela.ShowDialog();
            }
        }
    }
}


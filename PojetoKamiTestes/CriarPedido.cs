using PojetoKamiTestes;
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
    public partial class CriarPedido : Form
    {
        // ✅ AQUI SIM (dentro da classe)
        Pedidoandamento telaPedidos;

        Dictionary<string, (double preco, int quantidade)> pedido =
       new Dictionary<string, (double preco, int quantidade)>();

        private void LimparCheckboxes(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is CheckBox cb)
                {
                    cb.Checked = false;
                }
                else
                {
                    LimparCheckboxes(ctrl);
                }
            }
        }
        public CriarPedido()
        {
           
            InitializeComponent();
        }

        private void CriarPedido_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_FinalizarPedido_Click(object sender, EventArgs e)
        {

        }

        private void AtualizarPanel()
        {
            panelDados.Controls.Clear();

            int y = 10;
            double total = 0;

            foreach (var item in pedido)
            {
                string nome = item.Key;
                double preco = item.Value.preco;
                int qtd = item.Value.quantidade;

                Label lbl = new Label();
                lbl.Text = $"{nome} x{qtd} - R$ {(preco * qtd):F2}";
                lbl.Location = new Point(10, y);
                lbl.AutoSize = true;

                panelDados.Controls.Add(lbl);

                Button btnMais = new Button();
                btnMais.Text = "+";
                btnMais.Size = new Size(30, 25);
                btnMais.Location = new Point(250, y);

                btnMais.Click += (s, e) =>
                {
                    pedido[nome] = (preco, qtd + 1);
                    AtualizarPanel();
                };

                panelDados.Controls.Add(btnMais);

                Button btnMenos = new Button();
                btnMenos.Text = "-";
                btnMenos.Size = new Size(30, 25);
                btnMenos.Location = new Point(290, y);

                btnMenos.Click += (s, e) =>
                {
                    if (qtd > 1)
                    {
                        pedido[nome] = (preco, qtd - 1);
                    }
                    else
                    {
                        pedido.Remove(nome);
                    }

                    AtualizarPanel();
                };

                panelDados.Controls.Add(btnMenos);

                y += 30;
                total += preco * qtd;
            }

            Label lblTotal = new Label();
            lblTotal.Text = "TOTAL: R$ " + total.ToString("F2");
            lblTotal.Location = new Point(10, y + 10);
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Arial", 10, FontStyle.Bold);

            panelDados.Controls.Add(lblTotal);
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void btn_pedido_Click(object sender, EventArgs e)
        {
            pedido.Clear();

            foreach (Control grupo in this.Controls)
            {
                if (grupo is GroupBox)
                {
                    foreach (Control item in grupo.Controls)
                    {
                        if (item is CheckBox cb && cb.Checked)
                        {
                            double valor = Convert.ToDouble(cb.Tag.ToString());

                            pedido[cb.Text] = (valor, 1);
                        }
                    }
                }
            }

            AtualizarPanel();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lista_carne_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)


        {
            if (telaPedidos == null || telaPedidos.IsDisposed)
            {
                telaPedidos = new Pedidoandamento();
                telaPedidos.Show();
            }

            var copiaPedido = new Dictionary<string, (double preco, int quantidade)>(pedido);

            double total = 0;
            foreach (var item in copiaPedido)
            {
                total += item.Value.preco * item.Value.quantidade;
            }

            PedidoFinanceiro novoPedido = new PedidoFinanceiro
            {
                Numero = "",
                Itens = copiaPedido,
                Total = total,
                DataHora = DateTime.Now,
                FormaPagamento = "Não informado"
            };

            telaPedidos.AdicionarPedido(novoPedido);

            LimparCheckboxes(this);
            pedido.Clear();
            panelDados.Controls.Clear();

        }


        private void btn_pedidoAndto_Click(object sender, EventArgs e)
        {
            Pedidoandamento tela = new Pedidoandamento();
            tela.Show();
        }

        private void btn_criarPedido_Click(object sender, EventArgs e)
        {
            {
                CriarPedido tela = new CriarPedido();
                tela.Show();
            }
        }

        private void btn_financeiro_Click(object sender, EventArgs e)
        {
            Financeiro tela = new Financeiro();
            tela.Show();
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                 Application.Exit();
            }
        }
    }
}

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
    public partial class Pedidoandamento : Form
    {
        List<Panel> listaPanels;
        static int contadorPedidos = 1;

        public Pedidoandamento()
        {
            InitializeComponent();

            // 🔥 cria os panels aqui (sem depender do Load)
            listaPanels = new List<Panel>()
    {
        Pedido1,
        Pedido2,
        Pedido3,
        Pedido4,
        Pedido5,
        Pedido6
    };

            foreach (var p in listaPanels)
            {
                p.Visible = false;
            }
        }

        public void AdicionarPedido(PedidoFinanceiro pedido)
        {
            Panel painelLivre = listaPanels.FirstOrDefault(p => !p.Visible);

            if (painelLivre == null)
            {
                MessageBox.Show("Limite de pedidos atingido!");
                return;
            }

            pedido.Numero = contadorPedidos.ToString("D4");

            CriarCardPedido(painelLivre, pedido);
        }

        private void Pedidoandamento_Load(object sender, EventArgs e)
        {
            listaPanels = new List<Panel>()
    {
        Pedido1,
        Pedido2,
        Pedido3,
        Pedido4,
        Pedido5,
        Pedido6
    };

            // esconder todos no começo
            foreach (var p in listaPanels)
            {
                p.Visible = false;
            }
        }

        private void CriarCardPedido(Panel painel, PedidoFinanceiro pedido)
        {
            
                painel.Controls.Clear();
                painel.Visible = true;
                painel.Tag = pedido;

                Label titulo = new Label();
                titulo.Text = "Pedido #" + pedido.Numero;
                titulo.Font = new Font("Arial", 10, FontStyle.Bold);
                titulo.Location = new Point(10, 10);
                titulo.AutoSize = true;

                painel.Controls.Add(titulo);

                int y = 40;

                foreach (var item in pedido.Itens)
                {
                    Label lbl = new Label();
                    lbl.Text = $"{item.Key} x{item.Value.quantidade}";
                    lbl.Location = new Point(10, y);
                    lbl.AutoSize = true;

                    painel.Controls.Add(lbl);

                    y += 20;
                }

                Label lblTotal = new Label();
                lblTotal.Text = "Total: R$ " + pedido.Total.ToString("F2");
                lblTotal.Location = new Point(10, y + 10);
                lblTotal.AutoSize = true;

                painel.Controls.Add(lblTotal);

                Label lblData = new Label();
                lblData.Text = "Data: " + pedido.DataHora.ToString("dd/MM/yyyy HH:mm");
                lblData.Location = new Point(10, y + 30);
                lblData.AutoSize = true;

                painel.Controls.Add(lblData);

                Button btn = new Button();
                btn.Text = "Pedido concluído";
                btn.Size = new Size(130, 30);
                btn.Location = new Point(10, y + 60);

                btn.Click += (s, e) =>
                {
                    PedidoFinanceiro pedidoConcluido = (PedidoFinanceiro)painel.Tag;

                    if (Financeiro.Instancia == null || Financeiro.Instancia.IsDisposed)
                    {
                        Financeiro telaFinanceiro = new Financeiro();
                        telaFinanceiro.Show();
                    }

                    Financeiro.Instancia.AdicionarPedidoFinanceiro(pedidoConcluido);

                    painel.Controls.Clear();
                    painel.Visible = false;
                };

                painel.Controls.Add(btn);

                contadorPedidos++;
            }
        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_criarPedido_Click(object sender, EventArgs e)
        {
            {
                CriarPedido tela = new CriarPedido();
                tela.Show();
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
                tela.Show();
            }
        }

        private void btn_estoque_Click(object sender, EventArgs e)
        {
            {
                Estoque tela = new Estoque();
                tela.Show();
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
            {
                GerenFunc tela = new GerenFunc();
                tela.Show();
            }
        }
    }
}

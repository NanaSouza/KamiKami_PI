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
    public partial class Financeiro : Form
    {
        string kamikami = "server=localhost;uid=root;password=;database=kamikami;";
        
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
            MySqlConnection conn = new MySqlConnection(kamikami);
            try
            {
                conn.Open();
                string sql = "SELECT * pedido";
                MySqlCommand adp = new MySqlCommand(sql, conn);

                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(adp);

                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally 
            { 
                conn.Close();
            }

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

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                Application.Exit();
            }
        }
    }
}


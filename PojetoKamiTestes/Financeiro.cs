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

            CarregarPedidos();

        }

        public void CarregarPedidos()
        {
            using (MySqlConnection conn = new MySqlConnection(kamikami))
            {
                try
                {
                    conn.Open();

                    string sql = "SELECT p.id, p.forma_pagamento, p.data, p.status, SUM(ip.valor) AS Total FROM pedido p " +
                        "INNER JOIN itens_pedido ip ON p.id = ip.pedido_id " +
                        "GROUP BY p.id";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);

                    DataTable tabela = new DataTable();

                    adapter.Fill(tabela);

                    dataGridView1.DataSource = tabela;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar pedidos: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
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


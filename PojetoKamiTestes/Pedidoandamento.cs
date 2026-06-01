using MySql.Data.MySqlClient;
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
        string kamikami = "server=localhost;uid=root;password=;database=kamikami;";

        public Pedidoandamento()
        {
            InitializeComponent();
        }

        private void ListarPedidosPendentes()
        {
            MySqlConnection conexao = new MySqlConnection(kamikami);

            try
            {
                conexao.Open();

                string sqlPedido = "SELECT p.id, sum(ip.valor) as total " +
                                    "FROM pedido p " +
                                    "INNER JOIN itens_pedido ip ON p.id = ip.pedido_id " +
                                    "WHERE status = 'Em preparação' " +
                                    "GROUP BY p.id;";
                MySqlCommand cmd = new MySqlCommand(sqlPedido, conexao);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTablePedidos = new DataTable();
                adapter.Fill(dataTablePedidos);

                foreach (DataRow row in dataTablePedidos.Rows)
                {
                    string sqlItens = "SELECT ip.nome, ip.quantidade, ip.valor " +
                                        "FROM itens_pedido ip " +
                                        "WHERE pedido_id = @idPedido";
                    MySqlCommand cmdItens = new MySqlCommand(sqlItens, conexao);
                    cmdItens.Parameters.AddWithValue("@idPedido", row["id"]);
                    MySqlDataAdapter adapterItens = new MySqlDataAdapter(cmdItens);
                    DataTable dtItens = new DataTable();
                    adapterItens.Fill(dtItens);

                    UserControlPedidos card = new UserControlPedidos();
                    card.NumeroPedido = row["id"].ToString();
                    card.Valor = Convert.ToDouble(row["total"]).ToString("F2");
                    card.DataGridViewItensPedido.DataSource = dtItens;
                    tableLayoutPanelPedidos.Controls.Add(card);

                    card.ButtonFinalizar.Click += (s, e) =>
                    {
                        MySqlConnection conexaoBotao = new MySqlConnection(kamikami);

                        try
                        {
                            conexaoBotao.Open();
                            MySqlCommand cmdFinalizar = new MySqlCommand("UPDATE pedido SET status = 'Finalizado' WHERE id = @idPedido", conexaoBotao);
                            cmdFinalizar.Parameters.AddWithValue("@idPedido", row["id"]);
                            cmdFinalizar.ExecuteNonQuery();
                            tableLayoutPanelPedidos.Controls.Remove(card);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao finalizar pedido: " + ex.Message);
                        }
                        finally
                        {
                            conexaoBotao.Close();
                        }
                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void Pedidoandamento_Load(object sender, EventArgs e)
        {
            ListarPedidosPendentes();
        }

        private void btn_criarPedido_Click(object sender, EventArgs e)
        {
            CriarPedido tela = new CriarPedido();
            tela.Show();
        }

        private void btn_pedidoAndto_Click(object sender, EventArgs e)
        {
            Pedidoandamento tela = new Pedidoandamento();
            tela.Show();
        }

        private void btn_financeiro_Click(object sender, EventArgs e)
        {
            Financeiro tela = new Financeiro();
            tela.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

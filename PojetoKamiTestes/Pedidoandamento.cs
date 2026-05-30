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
            string sql = "SELECT * FROM pedido WHERE status = 'Em preparação';";

            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    UserControlPedidos card = new UserControlPedidos();

                    card.NumeroPedido = reader.GetInt32("id").ToString();
                    card.Cliente = "João";
                    card.Valor = "R$ 50,00";
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

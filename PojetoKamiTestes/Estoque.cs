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
    public partial class Estoque : Form
    {
        BindingList<Produto> produtos = new BindingList<Produto>();
        public Estoque()
        {
            InitializeComponent();
            ConfigurarDGV();
        }

        //Tabela de teste para ver se o produto esta sendo adicionado

        private void ConfigurarDGV()
        {
            dgv_produtos.AutoGenerateColumns = true;
            dgv_produtos.AllowUserToAddRows = false;
            dgv_produtos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_produtos.MultiSelect = false;
            dgv_produtos.ReadOnly = true;
            dgv_produtos.RowHeadersVisible = false;

            dgv_produtos.DataSource = produtos;
        }

        private void Estoque_Load(object sender, EventArgs e)
        {
            ConfigurarDGV();
            CarregarProdutos(); //usado ao conectar o banco de dados
        }
        private void CarregarProdutos()
        {
            //Receberar as informações do banco de dados e adicionar a lista de produtos
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_nome.Text)       ||
                string.IsNullOrWhiteSpace(txt_qtde.Text) ||
                string.IsNullOrWhiteSpace(txt_preco.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }
            if (!int.TryParse(txt_qtde.Text, out int quantidade))
            {
                MessageBox.Show("Quantidade deve ser um número inteiro.");
                return;
            }
            if (!decimal.TryParse(txt_preco.Text, out decimal preco))
            {
                MessageBox.Show("Digite um preço válido.");
                return;
            }
            //Produto p = new Produto
            //{
            //    Nome = txt_nome.Text,
            //    Codigo = GerarCodigo(),
            //    Quantidade = quantidade,
            //    Preco = preco
            //};

            //produtos.Add(p);
            //MessageBox.Show(produto.Count.ToString()); teste para verificar se o produto esta sendo adicionado a lista)

            LimparCampos();
            txt_codigo.Text = GerarCodigo();
            dgv_produtos.ClearSelection();
            dgv_produtos.CurrentCell = null;
        }
        private string GerarCodigo() //Gerar um código único para cada produto
        {
            int proxNum = produtos.Count + 1;
            return Guid.NewGuid().ToString("D3").Substring(0, 8).ToUpper();
        }

        private void LimparCampos() // habilita a função de limpar os campos apos adiicionar um produto
        {
            txt_nome.Clear();
            txt_qtde.Clear();
            txt_preco.Clear();
            txt_nome.Focus();
        }

        //Confguração do botão remover. Pede confirmação antes da exclusão
        private void btn_remover_Click(object sender, EventArgs e)
        {
            if (dgv_produtos.CurrentRow == null)
            {
                MessageBox.Show("Selecione um produto para remover.");
                return;
            }
            Produto produtoSelecionado = dgv_produtos.CurrentRow.DataBoundItem as Produto;
            if (produtoSelecionado == null)
            {
                MessageBox.Show("Selecione uma linha válida.");
                return;
            }
            DialogResult resultado = MessageBox.Show($"Deseja remover este item: {produtoSelecionado.Nome}?"
                , "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question
            );
            if (resultado == DialogResult.Yes)
            {
                produtos.Remove(produtoSelecionado);
                LimparCampos();
                dgv_produtos.ClearSelection();
                dgv_produtos.CurrentCell = null;
            }
        }

        private void dgv_produtos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Produto produtoSelecionado = dgv_produtos.Rows[e.RowIndex].DataBoundItem as Produto;
                if (produtoSelecionado != null)
                {
                    txt_nome.Text   = produtoSelecionado.Nome;
                    txt_codigo.Text = produtoSelecionado.Codigo;
                    txt_qtde.Text   = produtoSelecionado.Quantidade.ToString();
                    txt_preco.Text  = produtoSelecionado.Preco.ToString("F2");
                }
            }
        }
        //Configuração do botão editar. Permite editar as informações do produto selecionado

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (dgv_produtos.CurrentRow == null)
            {
                MessageBox.Show("Selecione um produto para editar.");
                return;
            }
            Produto produtoSelecionado = dgv_produtos.CurrentRow.DataBoundItem as Produto;

            if (produtoSelecionado == null)
            {
                MessageBox.Show("Selecione uma linha válida.");
                return;
            }
            if (!int.TryParse(txt_qtde.Text, out int quantidade))
            {
                MessageBox.Show("Quantidade Inválida. Digite um número inteiro.");
                return;
            }
            if (!decimal.TryParse(txt_preco.Text, out decimal preco))
            {
                MessageBox.Show("Preço Inválido. Digite um valor decimal.");
                return;
            }
            produtoSelecionado.Nome = txt_nome.Text;
            produtoSelecionado.Codigo = txt_codigo.Text;
            produtoSelecionado.Quantidade = quantidade;
            produtoSelecionado.Preco = preco;

            dgv_produtos.Refresh();
            LimparCampos();
            dgv_produtos.ClearSelection();
            dgv_produtos.CurrentCell = null;
            MessageBox.Show("Produto atualizado com sucesso!");
        }
        //Configurar botão Buscar

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string termo = txt_buscar.Text.Trim().ToLower();
            foreach (DataGridViewRow row in dgv_produtos.Rows)
            {
                Produto produto = row.DataBoundItem as Produto;
                if (produto != null)
                {
                    if (produto.Nome.ToLower().Contains(termo) ||
                        produto.Codigo.ToLower().Contains(termo))
                    {
                        row.Selected = true;
                        dgv_produtos.CurrentCell = row.Cells[0];
                        txt_buscar.Clear();
                        return;
                    }
                    
                }
            }
            MessageBox.Show("Produto não encontrado.");
        }
        //Função para dar baixa no estoque após a venda de um produto.
        public void DarBaixa (string codigoProduto, int quantidadeVendida)
        {
            Produto produto = produtos.FirstOrDefault(p => p.Codigo == codigoProduto);
            if (produto != null)
            {
                produto.Quantidade -= quantidadeVendida;
                if (produto.Quantidade < 0)
                    produto.Quantidade = 0;
                dgv_produtos.Refresh();
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
    }
}

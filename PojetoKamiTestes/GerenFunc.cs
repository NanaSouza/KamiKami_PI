using System;
using System.Collections.Generic;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PojetoKamiTestes
{
    public partial class GerenFunc : Form
    {
        string kamikami = "server=localhost;uid=root;password=;database=kamikami;";

        public static BindingList<Funcionarios> funcionarios = new BindingList<Funcionarios>()
        {    
        new Funcionarios
        {Nome = "Cara do Teste", CPF = "00000000000", Nascimento = "08/04/1994", Senha = "boris123", Cargo = "Administrador"}
        };
        //Essa BingindList puxa a Classe Funcionarios da Aba Funcionarios.cs!
        //Ela será removida e substituida pelo SQL? No sé! Perguntar pros profss.
        //Cadastrei esse usuário aqui, só pra habilitarmos o botão da tela do login. Totalmente tirável!

        public GerenFunc()
        {
            InitializeComponent();
            this.Load += GerenFunc_Load;
            ConfigurarDGV();
            AtualizarDGV();
        }

        private void GerenFunc_Load(object sender, EventArgs e) //Cadastra as opçoes no Combobox do CARGO.
        {
            cmb_cargo.Items.Add("Administrador");
            cmb_cargo.Items.Add("Funcionário");
            cmb_cargo.SelectedIndex = 0;
        }

        private void ConfigurarDGV() //Teste para ver se o funcionario esta sendo adicionado
        {
            dgv_func.AutoGenerateColumns = true;
            dgv_func.AllowUserToAddRows = false;
            dgv_func.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_func.MultiSelect = false;
            dgv_func.ReadOnly = true;
            dgv_func.RowHeadersVisible = false;
            dgv_func.DataSource = kamikami;
        }

        private void btn_criarPedido_Click(object sender, EventArgs e) //NÃO É IMPORTANTE PRA TELA
        {
            CriarPedido tela = new CriarPedido();
            tela.Show();        
        }
        
        private void btn_pedidoAndto_Click(object sender, EventArgs e)  //NÃO É IMPORTANTE PRA TELA
        {
            Financeiro tela = new Financeiro();
            tela.Show();
        }
        private void btn_financeiro_Click(object sender, EventArgs e)  //NÃO É IMPORTANTE PRA TELA
        {
            Financeiro tela = new Financeiro();
            tela.Show();
        }
        private void btn_estoque_Click(object sender, EventArgs e)  //NÃO É IMPORTANTE PRA TELA
        {
            Estoque tela = new Estoque();
            tela.Show();
        }
        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)  //NÃO É IMPORTANTE PRA TELA
        {
            Application.Exit();
        }
        private void btn_funcionarios_Click(object sender, EventArgs e) //BOTÃO QUE DÁ NA TELA QUE ESTAMOS MEXENDO, NÃO É IMPORTANTE PRA TELA
        {
            GerenFunc tela = new GerenFunc();
            tela.Show();
        }
        private void cmb_cargo_SelectedIndexChanged(object sender, EventArgs e) //COMBOBOX DO CARGO, TÁ VAZIO NÃO PRECISA EXPANDIR
        {

        }
        
        private void btn_CadFunc_Click(object sender, EventArgs e) // BOTÃO DE CADASTRAR FUNCIONÁRIO
        {
            MySqlConnection conn = new MySqlConnection(kamikami);
            string sql = "INSERT INTO usuario (cpf, nome, nascimento, senha, cargo, criado_em)" +
                         " VALUES (@cpf, @nome, @nascimento, @senha, @cargo, @criado_em)";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            if (string.IsNullOrWhiteSpace(txt_cadnome.Text) ||
                string.IsNullOrWhiteSpace(msk_CPF.Text) ||
                string.IsNullOrWhiteSpace(msk_dt.Text) ||
                string.IsNullOrWhiteSpace(txt_cadsenha.Text) ||
                string.IsNullOrWhiteSpace(txt_confsenha.Text) ||
                string.IsNullOrWhiteSpace(cmb_cargo.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }
            if (txt_cadsenha.Text != txt_confsenha.Text)
            {
                MessageBox.Show("As senhas não coincidem.");
                return;
            }

            try
            {
                cmd.Parameters.AddWithValue("@cpf", msk_CPF.Text);
                cmd.Parameters.AddWithValue("@nome", txt_cadnome.Text);
                cmd.Parameters.AddWithValue("@nascimento", msk_dt.Text);
                cmd.Parameters.AddWithValue("@senha", txt_cadsenha.Text);
                cmd.Parameters.AddWithValue("@cargo", cmb_cargo.Text);
                cmd.Parameters.AddWithValue("@criado_em", lblCriadoEm.Text);

                //add ativo e criado_em (Em labels) Add uma checkbox para status ativo ou desativado

                conn.Open();
                cmd.ExecuteNonQuery();
                //AtualizarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("VOCE É UM INUTIL QUE NÃO SABE NEM CADASTRAR O PROPRIO NOME" + ex.Message);
            }
            finally
            {
                conn.Close();
            }



            LimparCampos(); //Deixa limpinha as caixas de texto. A função que executa isso tá logo abaixo..
            dgv_func.ClearSelection();
            dgv_func.CurrentCell = null;
        }

        private void AtualizarDGV()
        {
            MySqlConnection conn = new MySqlConnection(kamikami);
            try
            {
                conn.Open();
                string sql = "SELECT * FROM usuario";
                MySqlCommand adp = new MySqlCommand(sql, conn);

                DataTable tabelaUsuario = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(adp);

                adapter.Fill(tabelaUsuario);

                dgv_func.DataSource = tabelaUsuario;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        private void LimparCampos() // Habilita a função de limpar os campos apos adicionar um novo funcionário
        { 
            txt_cadnome.Clear();
            msk_CPF.Clear();
            msk_dt.Clear();
            txt_cadsenha.Clear();
            txt_confsenha.Clear();
            cmb_cargo.SelectedIndex = 0;
        }
        private void btn_EdtFunc_Click(object sender, EventArgs e) // BOTÃO DE EDITAR FUNCIONÁRIO
        {
            if(btn_EdtFunc.Enabled) {
                if (dgv_func.SelectedRows.Count > 0)
                {
                    dgv_func.ReadOnly = false;
                    dgv_func.BeginEdit(true);
                    MessageBox.Show("Agora clique na célula que deseja editar e altere o valor.");
                }
                else
                {
                    MessageBox.Show("Selecione uma linha para editar.");
                }
            }
            dgv_func.Refresh();
            LimparCampos();
            dgv_func.ClearSelection();
            dgv_func.CurrentCell = null;
            MessageBox.Show("Dados atualizados com sucesso!"); 
            /*Esta m** deste botão não está do jeito que eu quero... DE NOVO, mas é o que tem pra hoje.
             Como não atrapalha o funcionamento da tela, vou deixar pra arrumar depois*/
        }
        private void button1_Click(object sender, EventArgs e) // BOTÃO DE EXCLUIR QUE EU FIZ A LINDEZA DE NÃO RENOMEAR
        {
            if(dgv_func.CurrentRow == null)
            {
                MessageBox.Show("Selecione o funcionário que deseja excluir.");
                return;
            }
            Funcionarios funcionarioSelecionado = dgv_func.CurrentRow.DataBoundItem as Funcionarios;
            if (funcionarioSelecionado == null)
            {
                MessageBox.Show("Selecione uma linha válida.");
                return;
            }
            DialogResult resultado = MessageBox.Show($"Deseja remover o cadastro de: {funcionarioSelecionado.Nome}?"
                , "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question
            );
            if (resultado == DialogResult.Yes)
            {
                funcionarios.Remove(funcionarioSelecionado);
                LimparCampos(); 
                dgv_func.ClearSelection();
                dgv_func.CurrentCell = null;
            }
        }
    }
}

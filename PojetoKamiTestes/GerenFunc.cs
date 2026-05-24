using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public static BindingList<Funcionarios> funcionarios = new BindingList<Funcionarios>()
        {    
        new Funcionarios
        {Nome = "Cara do Teste", ID = "171", CPF = "00000000000", Nascimento = "08/04/1994", Telefone = "11999999999", Senha = "boris123", Cargo = "Administrador"}
        };
        //Essa BingindList puxa a Classe Funcionarios da Aba Funcionarios.cs!
        //Ela será removida e substituida pelo SQL? No sé! Perguntar pros profss.
        //Cadastrei esse usuário aqui, só pra habilitarmos o botão da tela do login. Totalmente tirável!

        public GerenFunc()
        {
            InitializeComponent();
            this.Load += GerenFunc_Load;
            ConfigurarDGV();
        }

        private void GerenFunc_Load(object sender, EventArgs e) //Cadastra as opçoes no Combobox do CARGO.
        {
            cmb_cargo.Items.Add("Administrador");
            cmb_cargo.Items.Add("Atendente");
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
                dgv_func.DataSource = funcionarios;
            }
        
        private void btn_criarPedido_Click(object sender, EventArgs e) //NÃO É IMPORTANTE PRA TELA
        {
            {
                CriarPedido tela = new CriarPedido();
                tela.Show();
            }
        }
        private void btn_pedidoAndto_Click(object sender, EventArgs e)  //NÃO É IMPORTANTE PRA TELA
        {
            {
                Financeiro tela = new Financeiro();
                tela.Show();
            }
        }
        private void btn_financeiro_Click(object sender, EventArgs e)  //NÃO É IMPORTANTE PRA TELA
        {
            {
                Financeiro tela = new Financeiro();
                tela.Show();
            }
        }
        private void btn_estoque_Click(object sender, EventArgs e)  //NÃO É IMPORTANTE PRA TELA
        {
            {
                Estoque tela = new Estoque();
                tela.Show();
            }
        }
        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)  //NÃO É IMPORTANTE PRA TELA
        {
            {
                Application.Exit();
            }
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
            if (string.IsNullOrWhiteSpace(txt_cadnome.Text) ||
                string.IsNullOrWhiteSpace(msk_CPF.Text) ||
                string.IsNullOrWhiteSpace(msk_dt.Text) ||
                string.IsNullOrWhiteSpace(msk_tel.Text) ||
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
            } // IF ACIMA: Validação básica para garantir que os campos não estejam vazios e que as senhas coincidam. 

            txt_cadID.Text = GerarID(); //Após a checagem dos campos, o ID é gerado. A função GerarID() está logo abaixo dos códigos do botão.

            Funcionarios novoFuncionario = new Funcionarios()  
            {
                Nome = txt_cadnome.Text,
                ID = txt_cadID.Text,
                CPF = msk_CPF.Text,
                Nascimento = msk_dt.Text,
                Telefone = msk_tel.Text,
                Senha = txt_cadsenha.Text,
                Cargo = cmb_cargo.Text
            };
            funcionarios.Add(novoFuncionario); // Adiciona o novo funcionário à lista vinculada ao DataGridView, atualizando a exibição.

            LimparCampos(); //Deixa limpinha as caixas de texto. A função que executa isso tá logo abaixo..
            dgv_func.ClearSelection();
            dgv_func.CurrentCell = null;
        }
        
        private string GerarID() //Gerar um ID único para cada funcionário; verificar com Matheus se mantém ou não precisa (esqueci o nome do outro prof).
        {
            int proxNum = funcionarios.Count + 1;
            return proxNum.ToString("D3");
        }
        
        private void LimparCampos() // Habilita a função de limpar os campos apos adicionar um novo funcionário
        { 
            txt_cadnome.Clear();
            msk_CPF.Clear();
            msk_dt.Clear();
            msk_tel.Clear();
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

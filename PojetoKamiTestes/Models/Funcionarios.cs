using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PojetoKamiTestes
{
    public class Funcionarios //Estou usando essa classe para a tela de Gerenciamento de Funcionários.
    {
        public string Nome { get; set; }
        public string ID { get; set; }
        public string CPF { get; set; }
        public string Nascimento { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; }
        public string Cargo { get; set; }
    }

    public class PedidoFinanceiro //Talvez tenha que modificar essa quando alterar as telas de Pedido e Financeiro.
    {
        public string Numero { get; set; }
        public Dictionary<string, (double preco, int quantidade)> Itens { get; set; }
        public double Total { get; set; }
        public DateTime DataHora { get; set; }
        public string FormaPagamento { get; set; }
    }

    public class Produto //Essa é do Estoque, desconsiderar.
    {
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
    }

    public class Usuarios //Teria a mesma função da classe Funcionarios? Se sim, não precisa dessa. A outra Funcionarios já está de acordo com a tela.
    {
        public int Id { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string SenhaHash { get; set; }
        public string TipoUsuario { get; set; }
        public string Ativo { get; set; }  
        public string Tentativaslogin { get; set; }
        public string BloqueioAte { get; set; }
        public string UltimoAcesso { get; set; }
        public string TokenReset { get; set; }
        public string TokenExpira { get; set; }
        public string CriadoEm { get; set; }
        public string Status { get; set; }
        public int TentativasLogin { get; set; }  = 0;
    }
    public class LoginModel //Trabalhar com essa no domingo!
    {
        public string CPF { get; set; }
        public string Senha { get; set; }
        public bool LembrarMe { get; set; }
    }
    public class EsqueciSenhaModel //Trabalhar com essa no domingo!
    {
        public string CPF { get; set; }
        public string Email { get; set; }
    }
    public class RedefinirSenhaModel //Trabalhar com essa no domingo!
    {
        public string Token { get; set; }                
        public string NovaSenha { get; set; }                
        public string ConfirmarSenha { get; set; }
    }
}

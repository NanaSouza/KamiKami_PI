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
    public partial class UserControlPedidos : UserControl
    {
        public UserControlPedidos()
        {
            InitializeComponent();
        }

        public string NumeroPedido
        {
            get => labelNroPedido.Text;
            set => labelNroPedido.Text = value;
        }

        public string Valor
        {
            get => labelValor.Text;
            set => labelValor.Text = value;
        }
        public DataGridView DataGridViewItensPedido => dataGridViewItensPedido;

        public Button ButtonFinalizar => buttonFinalizar;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrandeLagoAzulPiscinas.Formularios
{
    public partial class fCadastroProduto : Form
    {
        public fCadastroProduto()
        {
            InitializeComponent();
            txtPreco.Text = "0.00";
        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

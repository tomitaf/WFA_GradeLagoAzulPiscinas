using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrandeLagoAzulPiscinas
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Não implementado");
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pessoaFísicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fCadastroPF frmCadastroPF = new fCadastroPF();
            frmCadastroPF.MdiParent = this;
            frmCadastroPF.Show();
        }

        private void pessoaJurídicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fCadastroPJ frmCadastroPJ = new fCadastroPJ();
            frmCadastroPJ.MdiParent = this;
            frmCadastroPJ.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Não implementado");
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Não implementado");
        }

        private void pessoaFísicaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Não implementado");
        }

        private void pessoaJurídicaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Não implementado");
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Não implementado");
        }

        private void versãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Versão 1.0");
        }
    }
}

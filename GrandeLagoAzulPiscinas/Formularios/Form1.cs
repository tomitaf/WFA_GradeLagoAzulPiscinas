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
using GrandeLagoAzulPiscinas.Formularios;

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
            frmCadastroPF.WindowState = FormWindowState.Maximized;
            frmCadastroPF.Show();
        }

        private void pessoaJurídicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fCadastroPJ frmCadastroPJ = new fCadastroPJ();
            frmCadastroPJ.MdiParent = this;
            frmCadastroPJ.WindowState = FormWindowState.Maximized;
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
            fConsultaClientePF frmCadastroPF = new fConsultaClientePF();
            frmCadastroPF.MdiParent = this;
            frmCadastroPF.WindowState = FormWindowState.Maximized;  //Garante que a tela será aberta maximizada
            frmCadastroPF.Show();
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

        private void fMain_Load(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void conectarDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strConn = "server=localhost;port=3306;User Id=root;database=dbGLAP;password=fmt12345";
            MySqlConnection conn = new MySqlConnection(strConn);
            try
            {
                conn.Open();
                MessageBox.Show("Conectado a dbGLAP");
                conn.Close();
                MessageBox.Show("Desconectado de dbGLAP");
            }
            catch(MySqlException except)
            {
                MessageBox.Show(except.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

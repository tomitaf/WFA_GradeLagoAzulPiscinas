using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GrandeLagoAzulPiscinas.Entidades;
using GrandeLagoAzulPiscinas.ServicosDB;
using MySql.Data.MySqlClient;

namespace GrandeLagoAzulPiscinas.Formularios
{
    public partial class fInserirPedidos : Form
    {


        public fInserirPedidos()
        {
            InitializeComponent();
            lblTotalPedido.Text = "R$ 0.00";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void fInserirPedidos_Load(object sender, EventArgs e)
        {

        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {

        }

        public AutoCompleteStringCollection AutoCompleteLoad()
        {
            AutoCompleteStringCollection acsc = new AutoCompleteStringCollection();
            MySqlConnection conn = new MySqlConnection(ServDbConnection.GetStrConnection());
            string query = "select cdNomeProduto, vlPreco from dbglap.t03_produtos";
            MySqlCommand cmd = new MySqlCommand(query,conn);
            try
            {
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                
                while (dr.Read())
                {
                    acsc.Add(dr["cdNomeProduto"].ToString());
                    acsc.Add(dr["vlPreco"].ToString());
                }
            }
            catch(Exception except)
            {
                statusBoxInserirPedidos.Text = except.Message;
                conn.Close();
            }
            finally
            {
                conn.Close();
            }
            return acsc;
        }

        private void dgvInserirPedidos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int col = dgvInserirPedidos.CurrentCell.ColumnIndex;
            string headerText = dgvInserirPedidos.Columns[col].HeaderText;
            if (headerText.Equals("Item"))
            {
                TextBox tb = e.Control as TextBox;
                if(tb != null)
                {
                    tb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    tb.AutoCompleteCustomSource = AutoCompleteLoad();
                    tb.AutoCompleteSource = AutoCompleteSource.CustomSource;
                }
            }
            else
            {
                TextBox tb = e.Control as TextBox;
                if(tb != null)
                {
                    tb.AutoCompleteMode = AutoCompleteMode.None;
                }
            }
        }
    }
}

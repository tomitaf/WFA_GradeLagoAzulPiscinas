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
                statusBarInserirPedidos.Text = except.Message;
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

        private void dgvInserirPedidos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 1)
                {
                    decimal cell1 = Convert.ToDecimal(dgvInserirPedidos.CurrentRow.Cells[1].Value);
                    decimal cell2 = Convert.ToDecimal(dgvInserirPedidos.CurrentRow.Cells[2].Value);
                    if (cell1.ToString() != "" && cell2.ToString() != "")
                    {
                        dgvInserirPedidos.CurrentRow.Cells[3].Value = cell1 * cell2;
                    }
                }
                decimal valorTotal = 0;
                string valor = "";
                if (dgvInserirPedidos.CurrentRow.Cells[3].Value != null)
                {
                    valor = dgvInserirPedidos.CurrentRow.Cells[3].Value.ToString();
                    if (!valor.Equals(""))
                    {
                        for (int i = 0; i <= dgvInserirPedidos.RowCount - 1; i++)
                        {
                            if (dgvInserirPedidos.Rows[i].Cells[3].Value != null)
                                valorTotal += Convert.ToDecimal(dgvInserirPedidos.Rows[i].Cells[3].Value);
                        }
                        lblTotalPedido.Text = valorTotal.ToString("C");
                    }
                }
            }
            catch (Exception ex)
            {
                statusBarInserirPedidos.Text = ex.Message;
            }
        }
    }
}

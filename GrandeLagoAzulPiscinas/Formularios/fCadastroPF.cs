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
using GrandeLagoAzulPiscinas.ServicosDB;

namespace GrandeLagoAzulPiscinas
{
    public partial class fCadastroPF : Form
    {
        public fCadastroPF()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            // Lê os dados digitados pelo usuário na tela de CadastroPF
            string nome = txtNomePF.Text;
            string cpf = txtCPF.Text;
            string endereco = txtEndereco.Text;
            string numeroEnd = txtEndNumPF.Text;
            string complementoEnd = txtEnderecoComplemento.Text;
            string bairro = txtBairro.Text;
            string cep = txtCEP.Text;
            string cidade = txtCidade.Text;
            string estado = txtEstado.Text;
            string telResidencial = txtTelResidencial.Text;
            string telComercial = txtTelComercial.Text;
            string telCelular = txtTelCelular.Text;
            string email = txtEmail.Text;

            //Monta a query de inserção
            string query = "insert into T01_CadastroClientesPF "
                + "(cdCpf,cdNome,cdLogradouro,cdEndNum,cdEndComplemento,cdBairro,cdCEP,cdCidade,cdEstado,TelRes,TelCel,TelCom,Email) values "
                + "('"
                + cpf.ToString() + "','"
                + nome + "','"
                + endereco + "','"
                + numeroEnd + "','"
                + complementoEnd + "','"
                + bairro + "','"
                + cep + "','"
                + cidade + "','"
                + estado + "','"
                + telResidencial + "','"
                + telCelular + "','"
                + telComercial + "','"
                + email + "')";
            //MessageBox.Show(cmd);
            
            
            MySqlConnection conn = new MySqlConnection(ServDbConnection.GetStrConnection());
            try
            {
                conn.Open();
                MySqlCommand cmdObj = new MySqlCommand(query,conn);
                cmdObj.ExecuteNonQuery();
                conn.Close();
                txtStatus.Text = "Novo cliente cadastrado";
                
            }
            catch(MySqlException except)
            {
                //MessageBox.Show(except.Message);
                conn.Close();
                txtStatus.Text = "Erro no cadastro: " + except.Message;
            }
            catch(Exception except)
            {
                txtStatus.Text = "Erro não tratado: " + except.Message;
            }
            finally
            {
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNomePF.Text = null;
            txtCPF.Text = null;
            txtEndereco.Text = null;
            txtEndNumPF.Text = null;
            txtEnderecoComplemento.Text = null;
            txtBairro.Text = null;
            txtCEP.Text = null;
            txtCidade.Text = null;
            txtEstado.Text = null;
            txtTelResidencial.Text = null;
            txtTelComercial.Text = null;
            txtTelCelular.Text = null;
            txtEmail.Text = null;
        }

        private void txtStatus_Click(object sender, EventArgs e)
        {
            txtStatus.Text = " ";
        }
    }
}

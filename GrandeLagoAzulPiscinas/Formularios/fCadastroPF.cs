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
using GrandeLagoAzulPiscinas.Formularios.Exceptions;

namespace GrandeLagoAzulPiscinas
{
    public partial class fCadastroPF : Form
    {
        public fCadastroPF()
        {
            InitializeComponent();
            stripStatLabelCadastroPF.Text = " ";
            txtTelResidencial.Text = "(11)";
            txtTelCelular.Text = "(11)";
            txtTelComercial.Text = "(11)";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            List<string> listaInputExcept = new List<string>();
            // Lê os dados digitados pelo usuário na tela de CadastroPF
            string cdNome = ExceptInput.ValidaInputString(txtNomePF.Text, "Nome", listaInputExcept);
            string cdCpf = ExceptInput.ValidaInputString(txtCPF.Text, "CPF", listaInputExcept);
            string cdLogradouro = txtEndereco.Text;
            string cdEndNum = txtEndNumPF.Text;
            string cdEndComplemento = txtEnderecoComplemento.Text;
            string cdBairro = txtBairro.Text;
            string cdCEP = txtCEP.Text;
            string cdCidade = txtCidade.Text;
            string cdEstado = cmbEstado.Text;
            string TelRes = ExceptInput.ValidaInputTelefone(txtTelResidencial.Text);
            string TelCom = ExceptInput.ValidaInputTelefone(txtTelComercial.Text);
            string TelCel = ExceptInput.ValidaInputTelefone(txtTelCelular.Text);
            string Email = txtEmail.Text;
            string Observacao = txtObservacaoPF.Text;

            MySqlConnection conn = new MySqlConnection(ServDbConnection.GetStrConnection());

            try
            {
                if (listaInputExcept.Count > 0) throw new FormException(listaInputExcept[0]);
                //Monta a query de inserção
                string query = "insert into T01_CadastroClientesPF "
                    + "(cdCpf,cdNome,cdLogradouro,cdEndNum,cdEndComplemento,cdBairro,cdCEP,cdCidade,cdEstado,TelRes,TelCel,TelCom,Email,Observacao) values "
                    + "('"
                    + cdCpf.ToString() + "','"
                    + cdNome + "','"
                    + cdLogradouro + "','"
                    + cdEndNum + "','"
                    + cdEndComplemento + "','"
                    + cdBairro + "','"
                    + cdCEP + "','"
                    + cdCidade + "','"
                    + cdEstado + "','"
                    + TelRes + "','"
                    + TelCel + "','"
                    + TelCom + "','"
                    + Email + "','"
                    + Observacao + "')";           
            
                conn.Open();
                MySqlCommand cmdObj = new MySqlCommand(query,conn);
                cmdObj.ExecuteNonQuery();
                conn.Close();
                stripStatLabelCadastroPF.Text = "Novo cliente cadastrado";
                
            }
            catch(MySqlException except)
            {
                //MessageBox.Show(except.Message);
                conn.Close();
                stripStatLabelCadastroPF.Text = "Erro no cadastro: " + except.Message;
            }
            catch(FormException except)
            {
                stripStatLabelCadastroPF.Text = "Erro nos dados digitados: " + except.Message;
            }
            finally
            {
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Limpa os valores digitados na tela de cadastro.
            txtNomePF.Text = null;
            txtCPF.Text = null;
            txtEndereco.Text = null;
            txtEndNumPF.Text = null;
            txtEnderecoComplemento.Text = null;
            txtBairro.Text = null;
            txtCEP.Text = null;
            txtCidade.Text = null;
            cmbEstado.Text = null;
            txtTelResidencial.Text = null;
            txtTelComercial.Text = null;
            txtTelCelular.Text = null;
            txtEmail.Text = null;
            txtObservacaoPF.Text = null;
        }

        private void txtStatus_Click(object sender, EventArgs e)
        {
       
        }

        private void fCadastroPF_Load(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}

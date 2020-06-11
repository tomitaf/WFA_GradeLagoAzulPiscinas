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
using MySql.Data.MySqlClient;
using GrandeLagoAzulPiscinas.ServicosDB;

namespace GrandeLagoAzulPiscinas.Formularios
{
    public partial class fConsultaClientePF : Form
    {
        public fConsultaClientePF()
        {
            InitializeComponent();
            lblResultadoPesquisa.Text = "";
            lblNome.Text = "";
            lblCPF.Text = "";
            lblLogradouro.Text = "";
            lblEndNUm.Text = "";
            lblEndComplemento.Text = "";
            lblCEP.Text = "";
            lblBairro.Text = "";
            lblCidade.Text = "";
            lblEstado.Text = "";
            lblTelRes.Text = "";
            lblTelCel.Text = "";
            lblTelCom.Text = "";
            lblEmail.Text = "";
            lblObservacao.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultaCadastroPF_Click(object sender, EventArgs e)
        {
            // Lê os dados de entrada
            
            string nome = txtNomeBusca.Text;
            string cpf = txtCPFBusca.Text;
            string logradouro = txtLogradouroBusca.Text;
            string telefone = txtTelBusca.Text;
            int contador = 0;
            HashSet<ClientePF> listaClientes = new HashSet<ClientePF>();
            HashSet<ClientePF> listaClientesAux = new HashSet<ClientePF>();
            HashSet<ClientePF> listaClientesTelefone = new HashSet<ClientePF>();
            cboxResBuscaPF.Items.Clear();
            LimpaTelaConsultaPF();
            MySqlConnection conn = new MySqlConnection(ServDbConnection.GetStrConnection());
            try
            {
                // Monta o conjunto de criterios satisfeitos
                if ((nome != "") || (cpf != "") || (logradouro != ""))
                {
                    contador++;
                    string query = FuncoesAuxiliares.fConsultaCLientePF(nome, cpf, logradouro);
                    //MessageBox.Show(query);
                    txtStatusBarConsultaPF.Text = query;
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader msqlDR = cmd.ExecuteReader();
                    while (msqlDR.Read())
                    {
                        ClientePF cliente = new ClientePF(msqlDR);
                        if (!listaClientes.Contains(cliente))
                        {
                            listaClientes.Add(cliente);
                        }
                    }
                }

                //Monta o conjunto de telefones encontrados
                if (telefone != "")
                {
                    contador ++;
                    listaClientesAux = FuncoesDB.GetClientePFByTel(telefone,1);
                    foreach(ClientePF cliente in listaClientesAux)
                    {
                        if (!listaClientesTelefone.Contains(cliente)) listaClientesTelefone.Add(cliente);

                    }
                    listaClientesAux = FuncoesDB.GetClientePFByTel(telefone, 2);
                    foreach (ClientePF cliente in listaClientesAux)
                    {
                        if (!listaClientesTelefone.Contains(cliente)) listaClientesTelefone.Add(cliente);

                    }
                    listaClientesAux = FuncoesDB.GetClientePFByTel(telefone, 3);
                    foreach (ClientePF cliente in listaClientesAux)
                    {
                        if (!listaClientesTelefone.Contains(cliente)) listaClientesTelefone.Add(cliente);
                    }
                    
                }
                conn.Close();
                if (contador == 0) lblResultadoPesquisa.Text = "Preencha algum dos campos para buscar";
                else {
                    if(contador == 2)
                    {
                        listaClientes.IntersectWith(listaClientesTelefone);
                    }
                    else 
                    {
                        if (listaClientesTelefone.Count > 0) listaClientes = listaClientesTelefone;
                    }
                    
                    if(listaClientes.Count == 0)
                    {
                        lblResultadoPesquisa.Text = "Nenhum cliente encontrado";
                    }
                    else if (listaClientes.Count == 1)
                    {
                        lblResultadoPesquisa.Text = "1 cliente encontrado";
                        foreach (ClientePF cliente in listaClientes) ImprimeClienteTela(cliente);
                    }
                    else
                    {
                        lblResultadoPesquisa.Text = listaClientes.Count + " clientes encontrados";
                        foreach (ClientePF cliente in listaClientes) cboxResBuscaPF.Items.Add(cliente.ToString());
                    }
                }
            }
            catch(Exception except)
            {
                MessageBox.Show(except.Message);
                conn.Close();
            }
            finally
            {
                conn.Close();
            }
            
        }
    

        private void lblResultadoPesquisaPF_Click(object sender, EventArgs e)
        {
            
        }

        private void fConsultaClientePF_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cpf = cboxResBuscaPF.Text.Substring(5,11);
            if(cpf.Length > 0)
            {
                ClientePF cliente = FuncoesDB.GetClientePFByCPF(cpf);
                ImprimeClienteTela(cliente);
            }
            

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void ImprimeClienteTela(ClientePF cliente)
        {
            lblNome.Text = cliente.Nome;
            lblCPF.Text = cliente.Cpf;
            lblLogradouro.Text = cliente.Logradouro;
            lblEndNUm.Text = cliente.NumEnd;
            lblEndComplemento.Text = cliente.ComplementoEnd;
            lblBairro.Text = cliente.Bairro;
            lblCEP.Text = cliente.Cep;
            lblCidade.Text = cliente.Cidade;
            lblEstado.Text = cliente.Estado;
            lblTelRes.Text = cliente.TelRes;
            lblTelCel.Text = cliente.TelCel;
            lblTelCom.Text = cliente.TelCom;
            lblEmail.Text = cliente.Email;
            lblObservacao.Text = cliente.Observacao;
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNomeBusca.Text = "";
            txtLogradouroBusca.Text = "";
            txtTelBusca.Text = "";
            txtCPFBusca.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Não implementado");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja deletar " + lblNome.Text + " (" + lblCPF.Text + ")?","Deletar cadastro",MessageBoxButtons.YesNo);
            if(dr == DialogResult.Yes)
            {
                string cpf = lblCPF.Text;
                string query = "delete from dbglap.t01_cadastroclientespf where cdCPF = '" + cpf + "'";
                MySqlConnection conn = new MySqlConnection(ServDbConnection.GetStrConnection());
                MySqlCommand cmd = new MySqlCommand(query, conn);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                
                }
                catch(Exception except)
                {
                    txtStatusBarConsultaPF.Text = except.Message;
                    conn.Close();
                }
                finally
                {
                    conn.Close();
                }
                LimpaTelaConsultaPF();
            }
            else
            {
                txtStatusBarConsultaPF.Text = "Operação cancelada";
            }
        }

        private void LimpaTelaConsultaPF()
        {
            lblResultadoPesquisa.Text = "";
            lblNome.Text = "";
            lblCPF.Text = "";
            lblLogradouro.Text = "";
            lblEndNUm.Text = "";
            lblEndComplemento.Text = "";
            lblCEP.Text = "";
            lblBairro.Text = "";
            lblCidade.Text = "";
            lblEstado.Text = "";
            lblTelRes.Text = "";
            lblTelCel.Text = "";
            lblTelCom.Text = "";
            lblEmail.Text = "";
            lblObservacao.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fInserirPedidos frmInserirPedido = new fInserirPedidos();
            //frmInserirPedido.MdiParent = fMain;
            frmInserirPedido.WindowState = FormWindowState.Maximized;
            frmInserirPedido.txtCliente.Text = lblNome.Text;
            frmInserirPedido.txtCpfCnpj.Text = lblCPF.Text;
            frmInserirPedido.cmbTipoCliente.Text = "Pessoa física";
            frmInserirPedido.Show();
        }
    }
}

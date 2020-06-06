using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using GrandeLagoAzulPiscinas.Entidades;
using System.Windows.Forms;
using GrandeLagoAzulPiscinas.ServicosDB;

namespace GrandeLagoAzulPiscinas.Entidades
{
    class FuncoesDB
    {
        public static ClientePF GetClientePFByCPF(string cpf)
        {
            
            MySqlConnection conn = new MySqlConnection(ServDbConnection.GetStrConnection());
            //MessageBox.Show("Objeto definido");
            try
            {
                List<ClientePF> listaClientes = new List<ClientePF>();
                string query = "select * from dbglap.t01_cadastroclientespf where cdCpf = '" + cpf + "'";
                MessageBox.Show(query);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query,conn);               
                MySqlDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Query executada");
                //dr.Read();
                //ClientePF cliente;
                while (dr.Read())
                {
                    listaClientes.Add(new ClientePF(dr));
                }
                
                conn.Close();
                return listaClientes[0];
                
            }
            catch(Exception except)
            {
                MessageBox.Show(except.Message);
                conn.Close();
                return null;
            }
            finally
            {
                conn.Close();
            }

        }
    }
}

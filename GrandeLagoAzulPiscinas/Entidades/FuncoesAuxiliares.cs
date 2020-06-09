using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandeLagoAzulPiscinas.Entidades
{
    class FuncoesAuxiliares
    {
        public static string ImprimeHashSet(HashSet<ClientePF> hashList)
        {
            StringBuilder sb = new StringBuilder();
            foreach(ClientePF cliente in hashList)
            {
                sb.AppendLine(cliente.Cpf + ", " + cliente.GetHashCode());
            }
            return sb.ToString();
            
        }
        public static string GetQueryBuscaPorTelefone(string tel, int col)
        {
            switch (col)
            {
                case 1:
                    return "select * from dbglap.t01_cadastroclientespf where TelRes like '%" + tel + "%'";
                    
                case 2:
                    return "select * from dbglap.t01_cadastroclientespf where TelCel like '%" + tel + "%'";
                    
                case 3:
                    return "select * from dbglap.t01_cadastroclientespf where TelCom like '%" + tel + "%'";
                default:
                    return "";
            }
        }
        public static string fConsultaCLientePF(string nome, string cpf, string logradouro)
        {
            int contador = 0;
            string query = "select * from dbglap.t01_cadastroclientespf where ";
            if (nome.Length > 0)
            {
                query += "cdNome like '%";
                query += nome + "%' ";
                contador += 1;
            }
            if (cpf.Length > 0)
            {
                if(contador > 0)
                {
                    query += "and cdCpf = '" + cpf + "' ";
                }
                else
                {
                    query += "cdCpf = '" + cpf + "' ";
                }
                contador += 1;
            }
            if (logradouro.Length > 0)
            {
                if(contador > 0)
                {
                    query += "and cdLogradouro like '%" + logradouro + "%' ";
                }
                else
                {
                    query += "cdLogradouro like '%" + logradouro + "%' ";
                }
            }




            return query;
        }
    }
}

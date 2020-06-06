using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandeLagoAzulPiscinas.Entidades
{
    class FuncoesAuxiliares
    {
        public static string fConsultaCLientePF(string nome, string cpf)
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
            }

            return query;
        }
    }
}

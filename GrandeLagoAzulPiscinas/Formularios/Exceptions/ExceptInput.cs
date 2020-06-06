using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandeLagoAzulPiscinas.Formularios.Exceptions
{
    static class ExceptInput
    {
        public static string ValidaInputString(string nome, string campo, List<string> listaExcept)
        {
            if (nome.Length == 0)
            {
                listaExcept.Add(campo + " não pode ser vazio");
                return "";
            }
            if (campo == "CPF")
            {
                if (nome.Length > 11)
                {
                    listaExcept.Add("Verifique a quantidade de dígitos no CPF");
                    return "";
                }
            }
            return nome;
        }
    }
}

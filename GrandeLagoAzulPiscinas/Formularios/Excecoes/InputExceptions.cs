using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandeLagoAzulPiscinas.Formularios.Excecoes
{
    class InputExceptions : ApplicationException
    {
        public InputExceptions(string mensagem) : base(mensagem)
        {
        }
    }
}

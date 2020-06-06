using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandeLagoAzulPiscinas.Formularios.Exceptions
{
    class FormException : ApplicationException
    {
        public FormException(string mensagem) : base(mensagem)
        { }
    }
}

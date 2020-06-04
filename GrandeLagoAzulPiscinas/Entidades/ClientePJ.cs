using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandeLagoAzulPiscinas.Entidades
{
    class ClientePJ : Cliente
    {
        public string CNPJ { get; set; }
        public Endereco EnderecoCobranca { get; set; }

    }
}

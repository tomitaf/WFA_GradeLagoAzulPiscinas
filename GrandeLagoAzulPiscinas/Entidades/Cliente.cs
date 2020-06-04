using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;   // Necessário para usar o MySQL 

namespace GrandeLagoAzulPiscinas.Entidades
{
    abstract class Cliente
    {
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        public string TelResidencial { get; set; }
        public string TelCelular { get; set; }
        public string TelComercial { get; set; }

        public Cliente()
        {
        }




    }
}

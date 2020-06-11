using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandeLagoAzulPiscinas.ServicosDB
{
    static class ServDbConnection
    {        
        public static string GetStrConnection()
        {
            return "server=localhost;port=3306;User Id=root;database=dbGLAP;password=fmt12345";
        }

       public static string GetStrConnection(string user, string pwd, string database)
        {
            return "server=localhost;port=3306;User Id=" + user + ";database=" + database + ";password=" + pwd + "";
        }
               
    }
}

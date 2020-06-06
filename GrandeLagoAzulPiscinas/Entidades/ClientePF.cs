using MySql.Data.MySqlClient;
namespace GrandeLagoAzulPiscinas.Entidades
{
    class ClientePF
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Logradouro { get; set; }
        public string NumEnd { get; set; }
        public string ComplementoEnd { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string TelRes { get; set; }
        public string TelCel { get; set; }
        public string TelCom { get; set; }
        public string Email { get; set; }
        public string Observacao { get; set; }

        public ClientePF(MySqlDataReader dr)
        {
            Cpf = dr["cdCpf"].ToString();
            Nome = dr["cdNome"].ToString();
            Logradouro = dr["cdLogradouro"].ToString();
            NumEnd = dr["cdEndNum"].ToString();
            ComplementoEnd = dr["cdEndComplemento"].ToString();
            Bairro = dr["cdBairro"].ToString();
            Cep = dr["cdCEP"].ToString();
            Cidade = dr["cdCidade"].ToString();
            Estado = dr["cdEstado"].ToString();
            TelRes = dr["TelRes"].ToString();
            TelCel = dr["TelCel"].ToString();
            TelCom = dr["TelCom"].ToString();
            Email = dr["Email"].ToString();
            Observacao = dr["Observacao"].ToString();
        }

        public override string ToString()
        {
            return "CPF: " + Cpf + ", Nome: " + Nome;
        }


    }
}

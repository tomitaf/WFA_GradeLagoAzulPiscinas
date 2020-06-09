using MySql.Data.MySqlClient;
using System.Text;
using System.Collections.Generic;

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
        public Pedido Pedido { get; set; }

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

        public string ToUpdateString(ClientePF cliente)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Update dbglap.t01_cadastroclientespf set ");
            sb.Append("cdNome = " + cliente.Nome + ", ");
            sb.Append("cdCpf = " + cliente.Cpf + ", ");
            sb.Append("cdLogradouro = " + cliente.Logradouro + ", ");
            sb.Append("cdEndNum = " + cliente.NumEnd + ", ");
            sb.Append("cdEndComplemento = " + cliente.ComplementoEnd + ", ");
            sb.Append("cdBairro = " + cliente.Bairro + ", ");
            sb.Append("cdCEP = " + cliente.Cep + ", ");
            sb.Append("cdCidade = " + cliente.Cidade + ", ");
            sb.Append("cdEstado = " + cliente.Estado + ", ");
            sb.Append("TelRes = " + cliente.TelRes + ", ");
            sb.Append("TelCel = " + cliente.TelCel + ", ");
            sb.Append("TelCom = " + cliente.TelCom + ", ");
            sb.Append("Email = " + cliente.Email + ", ");
            sb.Append("Observacao = " + cliente.Observacao + ", ");
            /* continuar o Append */
            return sb.ToString();
        }

        public string ToInsertString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO dbglap.t01_cadastroclientespf ((cdCpf,cdNome,cdLogradouro,cdEndNum,cdEndComplemento,cdBairro,cdCEP,cdCidade,cdEstado,TelRes,TelCel,TelCom,Email)) VALUES('");
            sb.Append(Nome + "',' ");
            sb.Append(Cpf + "',' ");
            sb.Append(Logradouro + "',' ");
            sb.Append(NumEnd + "',' ");
            sb.Append(ComplementoEnd + "',' ");
            sb.Append(Bairro + "',' ");
            sb.Append(Cep + "',' ");
            sb.Append(Cidade + "',' ");
            sb.Append(Estado + "',' ");
            sb.Append(TelRes + "',' ");
            sb.Append(TelCel + "',' ");
            sb.Append(TelCom + "',' ");
            sb.Append(Email + "',' ");
            sb.Append(Observacao + "') ");
            return sb.ToString();
        }

        public string ToDeleteString(string cpf)
        {
            return "Delete from dbglap.t01_cadastroclientespf where cdCpf = '" + Cpf + "'";
        }

        public override int GetHashCode()
        {
            return Cpf.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is ClientePF)) return false;
            ClientePF other = obj as ClientePF;
            return Cpf.Equals(other.Cpf);
        }

    }
}

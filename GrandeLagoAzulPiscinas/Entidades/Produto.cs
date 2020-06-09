namespace GrandeLagoAzulPiscinas.Entidades
{
    class Produto
    {
        public int Id { get; set; }
        public double Preco { get; set; }
        public double Qtd { get; set; }

        public Produto(int id, double preco, double qtd)
        {
            Id = id;
            Preco = preco;
            Qtd = qtd;
        }

    }
}

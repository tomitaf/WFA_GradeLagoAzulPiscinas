namespace GrandeLagoAzulPiscinas.Entidades
{
    class Produto
    {
        public string DescItem { get; set; }
        public double Preco { get; set; }
        public double Qtd { get; set; }

        public Produto(string descItem, double preco, double qtd)
        {
            DescItem = descItem;
            Preco = preco;
            Qtd = qtd;
        }

    }
}

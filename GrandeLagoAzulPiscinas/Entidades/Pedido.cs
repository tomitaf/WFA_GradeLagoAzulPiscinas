using System;
using System.Collections.Generic;

namespace GrandeLagoAzulPiscinas.Entidades
{
    class Pedido
    {
        public int Id { get; private set; }
        public List<Produto> ListaProdutos = new List<Produto>();
        public DateTime DataPedido { get; set; }

        public Pedido(int id, DateTime dataPedido)
        {
            Id = id;
            DataPedido = dataPedido;
        }

        public double GetValorTotal()
        {
            double total = 0;
            foreach(Produto prod in ListaProdutos)
            {
                total += prod.Qtd * prod.Preco;
            }
            return total;
        }


    }
}

using System;
using System.Collections.Generic;
using GrandeLagoAzulPiscinas.Entidades.Enums;

namespace GrandeLagoAzulPiscinas.Entidades
{
    class Pedido
    {
        public int Id { get; private set; }
        public List<Produto> ListaProdutos = new List<Produto>();
        public DateTime DataPedido { get; set; }
        public string FormaPagamento { get; set; }
        public StatusPagamento StatusPagamento { get; set; }
        public string Observacoes { get; set; }

        public Pedido(int id, List<Produto> listaProdutos, DateTime dataPedido, 
            string formaPagamento, StatusPagamento statusPagamento, string observacoes)
        {
            Id = id;
            ListaProdutos = listaProdutos;
            DataPedido = dataPedido;
            FormaPagamento = FormaPagamento;
            StatusPagamento = statusPagamento;
            Observacoes = observacoes;
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

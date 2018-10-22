using System;
using System.Collections.Generic;
using System.Globalization;


namespace notaproduto.dominio
{
    class ItemPedido
    {
        //Criando variaveis do ItemPedido
        public int quantidade { get; set; }
        public double porcentagemDesconto { get; set; }
        public Produto produto { get; set; }
        public Pedido pedido { get; set; }

        //Criando construtor do ItemPedido
        public ItemPedido (int quantidade, double porcentagemDesconto, Pedido pedido, Produto produto)
        {
            this.quantidade = quantidade;
            this.porcentagemDesconto = porcentagemDesconto;
            this.pedido = pedido;
            this.produto = produto;            
        }

        //Criando metodo subTotal
        public double subTotal()
        {
            double desconto = produto.preco * porcentagemDesconto / 100.00;
            return (produto.preco - desconto) * quantidade;
        }


        //Metodo para apresentar a class ItemPedido
        public override string ToString()
        {
            return produto.descricao
                + ", Preco: "
                + produto.preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", Qte: "
                + quantidade
                + ", Desconto: "
                + porcentagemDesconto.ToString("F2", CultureInfo.InvariantCulture)
                + " %, SubTotal: "
                + subTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

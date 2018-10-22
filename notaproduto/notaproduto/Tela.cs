using System;
using System.Globalization;
using notaproduto.dominio;
using System.Collections.Generic;


namespace notaproduto
{
    class Tela
    {
        public static void mostrarMenu()
        {
            Console.WriteLine("1 - Listar produtos ordenadamente");
            Console.WriteLine("2 - Cadastrar produto");
            Console.WriteLine("3 - Cadastrar pedido");
            Console.WriteLine("4 - Mostrar dados do pedido");
            Console.WriteLine("5 - Sair");
            Console.Write("Digite uma opcao: ");
        }

        public static void mostrarProduto()
        {
            Console.WriteLine("LISTAGEM DE PRODUTO");
            for(int i = 0; i < Program.produtos.Count; i++)
            {
                Console.WriteLine(Program.produtos[i]);
            }
        }

        public static void cadastrarProduto()
        {
            Console.WriteLine("Digite os dados do produto: ");
            Console.Write("Codigo: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Descricao: ");
            string descricao = Console.ReadLine();
            Console.Write("Preco: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Produto p = new Produto(codigo, descricao, preco);
            Program.produtos.Add(p);
            Program.produtos.Sort();

        }

        public static void cadastrarPedido()
        {
            Console.WriteLine("Digite os dados do pedido: ");
            //Cadastrando dados da class Pedido
            Console.Write("Codigo: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Dia: ");
            int dia = int.Parse(Console.ReadLine());
            Console.Write("Mes: ");
            int mes = int.Parse(Console.ReadLine());
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());
            Pedido p = new Pedido(codigo, dia, mes, ano);
            //Dados na class Pedido cadastrado

            //Cadastrando dados da class ItemPedido
            Console.Write("Quantos itens tem o pedido: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Digite os dados do " + i + " item");
                Console.Write("Produto (codigo): ");
                int codProduto = int.Parse(Console.ReadLine());
                int pos = Program.produtos.FindIndex(x => x.codigo == codProduto);
                if(pos == -1)
                {
                    throw new ModelException("Codigo e produto nao encontrado: " + codProduto);
                }
                Console.Write("Quantidade: ");
                int qte = int.Parse(Console.ReadLine());
                Console.Write("Porcentagem de desconto: ");
                double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                ItemPedido ip = new ItemPedido(qte, porcent, p, Program.produtos[pos]);
                p.itens.Add(ip);
                Console.WriteLine();
            }
            //Dados na class ItemPedido cadastrado

            Program.pedidos.Add(p);
        }

        public static void mostrarPedido()
        {
            Console.Write("Digite o codigo do pedido: ");
            int codPedido = int.Parse(Console.ReadLine());
            int pos = Program.pedidos.FindIndex(x => x.codigo == codPedido);
            if (pos == -1)
            {
                throw new ModelException("Codigo de pedido nao encontrado: " + codPedido);
            }
            Console.WriteLine(Program.pedidos[pos]);
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using curso.Dominio;

namespace Name
{
    class Program
    {
        public static List<Produto> produtos = new List<Produto>();
        public void Main(string[] args)
        {
            int opcao = 0;

            produtos.Add(new Produto (1001, "Cadeira simples", 500.00));
            produtos.Add(new Produto (1002, "Cadeira acolchoada", 900.00));
            produtos.Add(new Produto (1003, "Sofa de tres lugares", 2000.00));
            produtos.Add(new Produto (1004, "Mesa retangular", 1500.00));
            produtos.Add(new Produto (1005, "Mesa retangular", 2000.00));


            while(opcao != 5)
            {
                Console.Clear();
                Tela.mostrarMenu();
                try{
                    opcao = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.Write("Erro inesperado: " + e.Message);
                    opcao = 0;
                }
            }

            switch (opcao)
            {
                case 1:
                    Tela.mostrarProduto();

                case 2:

                case 3:

                case 4:

                case 5:
                    Console.WriteLine("Fim do programa!");

                default:
                    Console.WriteLine("Opcao invalida!");
            }

            Console.ReadLine();
        }
    }
}

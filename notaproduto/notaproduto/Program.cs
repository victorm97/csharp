using System;
using System.Collections.Generic;
using notaproduto.dominio;

namespace notaproduto
{
    class Program
    {
        public static List<Produto> produtos = new List<Produto>();
        public static List<Pedido> pedidos = new List<Pedido>();
        static void Main(string[] args)
        {
            int opcao = 0;

            produtos.Add(new Produto(1001, "Cadeira simples", 500.00));
            produtos.Add(new Produto(1002, "Cadeira acolchoada", 900.00));
            produtos.Add(new Produto(1003, "Sofa para tres", 2000.00));
            produtos.Add(new Produto(1004, "Mesa retangular", 1500.00));
            produtos.Add(new Produto(1005, "Mesa retangular", 2000.00));
            produtos.Sort();

            while(opcao != 5)
            {
                Console.Clear();
                Tela.mostrarMenu();
                try
                {
                    opcao = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro inesperado" + e.Message);
                    opcao = 0;
                }
                Console.WriteLine();

                switch(opcao)
                {
                    case 1:
                        try
                        {
                            Tela.mostrarProduto();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Erro inesperado" + e.Message);
                            opcao = 0;
                        }
                        break;
                    case 2:
                        try
                        {
                            Tela.cadastrarProduto();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Erro inesperado" + e.Message);
                            opcao = 0;
                        }
                        break;
                    case 3:
                        try
                        {
                            Tela.cadastrarPedido();
                        }
                        catch (ModelException e)
                        {
                            Console.WriteLine("Erro de negocio: " + e.Message);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Erro inesperado" + e.Message);
                            opcao = 0;
                        }
                        break;
                    case 4:
                        try
                        {
                            Tela.mostrarPedido();
                        }
                        catch (ModelException e)
                        {
                            Console.WriteLine("Erro de negocio: " + e.Message);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Erro inesperado" + e.Message);
                            opcao = 0;
                        }
                        break;
                    case 5:
                        Console.WriteLine("Fim do programa");
                        break;
                    default:
                        Console.WriteLine("Opcao invalida");
                        break;
                }
                Console.ReadLine();    
                
            }
            
        }
    }
}

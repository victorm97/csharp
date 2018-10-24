using System;
using System.Collections.Generic;
using Revendedora.dominio;


namespace Revendedora
{
    class Program
    {
        public static List<Marca> marcas = new List<Marca>();
        public static List<Carro> carros = new List<Carro>();
        static void Main(string[] args)
        {
            int opcao = 0;

            //Inicializando as marcas
            Marca m1 = new Marca(1001, "Volkswagen", "Alemanha");
            Marca m2 = new Marca(1002, "General Motors", "Estados Unidos");

            //Inicializando os carros
            Carro c1 = new Carro(101, "Fusca", 1980, 5000.00, m1);
            Carro c2 = new Carro(102, "Golf", 2016, 60000.00, m1);
            Carro c3 = new Carro(103, "Fox", 2017, 30000.00, m1);
            Carro c4 = new Carro(104, "Cruze", 2016, 30000.00, m2);
            Carro c5 = new Carro(105, "Cobalt", 2015, 25000.00, m2);
            Carro c6 = new Carro(106, "Cobalt", 2017, 35000.00, m2);

            //Adicionando carros nas marcas
            m1.addCarro(c1);
            m1.addCarro(c2);
            m1.addCarro(c3);
            m2.addCarro(c4);
            m2.addCarro(c5);
            m2.addCarro(c6);

            //Armazenando marcas e carros na lista
            marcas.Add(m1);
            marcas.Add(m2);
            carros.Add(c1);
            carros.Add(c2);
            carros.Add(c3);
            carros.Add(c4);
            carros.Add(c5);
            carros.Add(c6);

            //Inicializando menu
            while(opcao != 7)
            {
                Console.Clear();
                Tela.mostrarMenu();
                try
                {
                    opcao = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro inesperado " + e.Message);
                    opcao = 0;
                }

                switch (opcao)
                {
                    case 1:
                        try
                        {
                            Tela.listarMarcas();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Erro inesperado " + e.Message);
                            opcao = 0;
                        }
                        break;

                    case 2:
                        try
                        {
                            Tela.listarCarros();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Erro inesperado " + e.Message);
                            opcao = 0;
                        }
                        break;

                    case 3:
                        try
                        {
                            Tela.cadastrarMarca();
                        }
                        catch (ModelException e)
                        {
                            Console.WriteLine("Erro de negocio " + e.Message);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Erro inesperado " + e.Message);
                            opcao = 0;
                        }
                        break;

                    case 4:
                        try
                        {
                            Tela.cadastrarCarro();
                        }
                        catch (ModelException e)
                        {
                            Console.WriteLine("Erro de negocio " + e.Message);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Erro inesperado " + e.Message);
                            opcao = 0;
                        }
                        break;

                    case 5:
                        try
                        {
                            Tela.cadastrarAcessorio();
                        }
                        catch (ModelException e)
                        {
                            Console.WriteLine("Erro de negocio " + e.Message);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Erro inesperado " + e.Message);
                            opcao = 0;
                        }
                        break;

                    case 6:
                        try
                        {
                            Tela.mostrarCarro();
                        }
                        catch (ModelException e)
                        {
                            Console.WriteLine("Erro de negocio " + e.Message);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Erro inesperado " + e.Message);
                            opcao = 0;
                        }
                        break;

                    case 7:
                        Console.WriteLine("Fim do programa!");
                        break;

                    default:
                        Console.WriteLine("Opcao invalida!");
                        break;
                }
                Console.ReadLine();
            }

        }
    }
}

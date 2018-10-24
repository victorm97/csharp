using System;
using System.Collections.Generic;
using System.Globalization;
using Revendedora.dominio;

namespace Revendedora
{
    class Tela
    {
        public static void mostrarMenu()
        {
            Console.WriteLine("1 – Listar marcas");
            Console.WriteLine("2 – Listar carros de uma marca ordenadamente*");
            Console.WriteLine("3 – Cadastrar marca");
            Console.WriteLine("4 – Cadastrar carro");
            Console.WriteLine("5 – Cadastrar acessório");
            Console.WriteLine("6 – Mostrar detalhes de um carro");
            Console.WriteLine("7 – Sair");
            Console.Write("Escolha uma opcao: ");
        }

        public static void listarMarcas()
        {
            Console.WriteLine("LISTAGEM  DE MARCAS:");
            for(int i = 0; i < Program.marcas.Count; i++)
            {
                Console.WriteLine(Program.marcas[i]);
            }
        }

        public static void listarCarros()
        {
            Console.Write("Digite o codigo da marca: ");
            int codMarca = int.Parse(Console.ReadLine());
            int pos = Program.marcas.FindIndex(x => x.codigo == codMarca);
            if(pos == -1)
            {
                throw new ModelException("Codigo da marca nao encontrado: " + codMarca);
            }
            Console.WriteLine("Carros da marca " + Program.marcas[pos].nome);
            List<Carro> c = new List<Carro>(Program.marcas[pos].carros);
            for(int i = 0; i < c.Count; i++)
            {
                Console.WriteLine(c[i]);
            }
        }

        public static void cadastrarMarca()
        {
            Console.WriteLine("Digite os dados da marca:");
            Console.Write("Codigo: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Pais de origem: ");
            string pais = Console.ReadLine();
            Marca c = new Marca(codigo, nome, pais);
            Program.marcas.Add(c);
        }

        public static void cadastrarCarro()
        {
            Console.WriteLine("Digite os dados do carro:");
            Console.Write("Marca (codigo): ");
            int codMarca = int.Parse(Console.ReadLine());
            int pos = Program.marcas.FindIndex(x => x.codigo == codMarca);
            if(pos == -1)
            {
                throw new ModelException("Codigo da marca nao encontrado " + codMarca);
            }
            Console.Write("Codigo do carro: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());
            Console.Write("Preco basico: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Carro c = new Carro(codigo, modelo, ano, preco, Program.marcas[pos]);
            Program.marcas[pos].addCarro(c);
            Program.carros.Add(c);
        }

        public static void cadastrarAcessorio()
        {
            Console.WriteLine("Digite os dados do acessorio:");
            Console.Write("Carro (codigo): ");
            int codCarro = int.Parse(Console.ReadLine());
            int pos = Program.carros.FindIndex(x => x.codigo == codCarro);
            if(pos == -1)
            {
                throw new ModelException("Codigo do carro nao encontrado " + codCarro);
            }
            Console.Write("Descricao: ");
            string descricao = Console.ReadLine();
            Console.Write("Preco: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Acessorio a = new Acessorio(descricao, preco, Program.carros[pos]);
            Program.carros[pos].acessorios.Add(a);
        }

        public static void mostrarCarro()
        {
            Console.Write("Digite o codigo do carro: ");
            int codCarro = int.Parse(Console.ReadLine());
            int pos = Program.carros.FindIndex(x => x.codigo == codCarro);
            if(pos == -1)
            {
                throw new ModelException("Codigo do carro nao encontrado " + codCarro);
            }
            Console.WriteLine(Program.carros[pos]);
        }
    }
}

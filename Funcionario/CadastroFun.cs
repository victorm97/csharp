using System;
using System.Globalization;
using System.Collections.Generic;

namespace Empresa
{
    class Program
    {
        static void main(string[] args)
        {
            Console.Write("Quantos funcionarios serao cadastrados: ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> lista = new List<Funcionario>();

            Console.WriteLine("DADOS DO FUNCIONARIO");

            for(int i = 1; i <= n; i++)
            {
                Console.Write("CPF: ");
                string cpf = Console.ReadLine();
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: R$ ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Funcionario f = new Funcionario(cpf, nome, salario);
                lista.Add(f);
                Console.WriteLine();
            }

            Console.Write("Digite o cpf do funcionario que tera aumento: ");
            string buscadorcpf = Console.ReadLine();

            int pos = lista.FindIndex(x => x.cpf == buscadorcpf);
            if(pos == -1)
            {
                Console.WriteLine("CPF INEXISTENTE");
            }
            else
            {
                Console.Write("Digite a porcentagem de aumento: ");
                double porc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                lista[pos].aumentarSalario(porc);
            }

            Console.WriteLine();
            Console.WriteLine("DADOS ATUALIZADOS: ");
            Console.WriteLine();

            for(int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }
            
            Console.ReadLine();

        }
    }
}

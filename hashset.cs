using System;
using System.Collections.Generic;

namespace curso
{
    class Program
    {
        static void main(string[] args)
        {
            //Criando Colecao
            HashSet<int> a = new HashSet<int>();
            HashSet<int> b = new HashSet<int>();
            HashSet<int> c = new HashSet<int>();

            //Solicitando numero de alunos para o usuario
            Console.Write("O curso A possui quantos alunos: ");
            int n = int.Parse(Console.ReadLine());

            //Pulando uma linha !
            Console.WriteLine(); 
            //Loop para salvar codigos dos alunos
            Console.WriteLine("Digite os codigos dos alunos: "); 
            for(int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                a.Add(x);
            }

            //Pulando uma linha !
            Console.WriteLine();
            //Solicitando numero de alunos para o usuario 
            Console.Write("O curso B possui quantos alunos: ");
            n = int.Parse(Console.ReadLine());

            //Pulando uma linha !
            Console.WriteLine();
            //Loop para salvar codigos dos alunos
            Console.WriteLine("Digite os codigos dos alunos: ");
            for(int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                b.Add(x);
            }

            //Pulando uma linha!
            Console.WriteLine();
            //Solicitando numero de alunos para o usuario
            Console.Write("O curso C possui quantos alunos: ");
            n = int.Parse(Console.ReadLine());

            //Pulando uma linha!
            Console.WriteLine();
            //Loop para salvar codigos dos alunos
            Console.WriteLine("Digite os codigos dos alunos: ");
            for(int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                c.Add(x);
            }

            //Criando colecao para contar todos os alunos
            HashSet<int> novo = new HashSet<int>();
            //Unindo colecoes a, b e c na colecao novo
            novo.UnionWith(a);
            novo.UnionWith(b);
            novo.UnionWith(c);
            //Apresentando para o usuario numero total de alunos
            Console.WriteLine("Total de alunos: " + novo.Count);

            //Parando codigo !
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> a = new HashSet<int>(); //instanciando um conjunto
            HashSet<int> b = new HashSet<int>();

            a.Add(3);
            a.Add(5);
            a.Add(8);
            a.Add(9);

            b.Add(3);
            b.Add(4);
            b.Add(5);

            b.Remove(4); //Funcao para remover elemento do conjunto

            a.ExceptWith(b); //Funcao para remover elemento de dois conjuntos que sao iguais
            a.UnionWith(b); //Funcao para unir elemento que nao tem em um conjunto
            a.IntersectWith(b); //Funcao para apresentar elementos que tem nos dois conjuntos

            foreach (int x in a)
            {
                Console.WriteLine(x);
            }

            Console.Write("Digite um valor inteiro: ");
            int n = int.Parse(Console.ReadLine());

            if(a.Contains(n)) //Funcao para encontrar um elemento dentro do conjunto
            {
                Console.WriteLine(a + " pertence ao conjunto a");
            }    
            else
            {
                Console.WriteLine(a + " nao pertence ao conjunto a");
            }

            Console.ReadLine();

        }
    }
}

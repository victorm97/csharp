using System;
using System.Collections.Generic;
using System.Globalization;

namespace curso
{
    class program
    {
        static void Main(string[] args)
        {
            List<figura> lista = new List<figura>();

            Console.Write("Quantas figuras voce vai digitar: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.Write("Figura " + i + " - Retangulo ou Triangulo (r/t)? ");
                char c = char.Parse(Console.ReadLine());
                if(c == 'r')
                {
                    figura f = tela.lerRetangulo();
                    lista.Add(f);   
                }
                else if (c == 't')
                {
                    figura f = tela.lerTriangulo();
                    lista.Add(f);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Areas das figuras: ");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Figura " + (i+1) + ": " + lista[i].area().ToString("F1", CultureInfo.InvariantCulture));
            }

            Console.ReadLine();
        }
    }
}

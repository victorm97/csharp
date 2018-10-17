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
                    Console.Write("Largura: ");
                    double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Altura: ");
                    double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    figura f = new retangulo(largura, altura);
                    lista.Add(f);
                }
                else if (c == 'r')
                {
                    Console.Write("Lado A: ");
                    double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Lado B: ");
                    double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Lado C: ");
                    double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    figura f = new triangulo(a,b,c);
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

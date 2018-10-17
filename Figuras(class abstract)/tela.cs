using System;
using System.Globalization;

namespace curso
{
    class tela
    {
        public static retangulo lerRetangulo()
        {
            Console.Write("Largura: ");
            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Altura: ");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            figura f = new retangulo(largura, altura);
        }

        public static triangulo lerTriangulo()
        {
            Console.Write("Lado A: ");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado B: ");
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado C: ");
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            figura f = new triangulo(a,b,c);
        }
    }
}

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
    }
}

using System;

namespace curso
{
    class Retangulo : Figura
    {
        public double largura {get; set;}
        public double altura {get; set; }

        public Retangulo (double largura, double altura)
        {
            this.largura = largura;
            this.altura = altura;
        }

        public override double area()
        {
            return largura * altura;
        }        
    }
}

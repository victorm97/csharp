using System;
using System.Globalization;

namespace curso
{
    class Produto : IComparable
    {
        public int codigo {get; set;}
        public string descricao {get; set;}
        public double preco {get; set;}

        public int CompareTo(object obj)
        {
            Produto outro = (Produto)obj;
           int resultado = descricao.CompareTo(outro.descricao);
           if(resultado != 0)
           {
               return resultado;
           }
           else
           {
               return -preco.CompareTo(outro.preco);
           }
        }
        

        public override string ToString()
        {
            return codigo
                + ", "
                + descricao
                + ", "
                + preco.ToString("F2", CultureInfo.InvariantCulture); 
        }
    }
}

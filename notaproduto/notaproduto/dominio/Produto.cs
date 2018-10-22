using System;
using System.Globalization;



namespace notaproduto.dominio
{
    class Produto : IComparable
    {
        //Criando variaveis do produto
        public int codigo { get; set; }
        public string descricao { get; set; }
        public double preco { get; set; }
        
        //Criando construtor do produto
        public Produto (int codigo, string descricao, double preco)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.preco = preco;
        }

        //Organizando por ordem alfabetica ou valor
        public int CompareTo(object obj)
        {
            Produto outro = (Produto)obj;
            int resultado = descricao.CompareTo(outro.descricao);
            if (resultado != 0)
            {
                return resultado;
            }
            else
            {
                return -preco.CompareTo(outro.preco);
            }
        }

        //Codigo para definir como a class produto sera apresentada
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

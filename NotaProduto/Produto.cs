namespace curso
{
    class Produto
    {
        public int codigo {get; set;}
        public string descricao {get; set;}
        public double preco {get; set;}

        public override string ToString()
        {
            return codigo
                + ", "
                + descricao
                + ", "
                + preco; 
        }
    }
}

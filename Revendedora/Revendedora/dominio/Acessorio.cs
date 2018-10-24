using System;
using System.Globalization;

namespace Revendedora.dominio
{
    class Acessorio
    {
        public string descricao { get; set; }
        public double preco { get; set; }
        public Carro carro { get; set; }

        public Acessorio(string descricao, double preco, Carro carro)
        {
            this.descricao = descricao;
            this.preco = preco;
            this.carro = carro;
        }

        public override string ToString()
        {
            return descricao
                + ", Preco: "
                + preco.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}

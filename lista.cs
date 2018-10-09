using System;
using System.Collections.Generic;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> lista = new List<string>();

            //Adicionando dados a lista
            lista.Add(new Produto("TV", 900.00));
            lista.Add(new Produto("Aspirador", 400.00));
            lista.Add(new Produto("Geladeira", 2000.00));
            
            int pos = lista.FindIndex(x => x.nome == "Aspirador"); //Encontra a posicao
            Console.WriteLine("Posicao da Maria = " + pos);

            for(int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }
        }
    }
    
}

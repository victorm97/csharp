using System;
namespace curso
{
    class Tela
    {
        /*Classe responsavel por conter operacoes que interagem com o
        usuario no modo console */

        public static void mostrarMenu()
        {
            Console.WriteLine("1 - Listar produtos ordenadamente");
            Console.WriteLine("2 - Cadastrar produto");
            Console.WriteLine("3 - Cadastrar pedido");
            Console.WriteLine("4 - Mostrar dados de um pedido");
            Console.WriteLine("5 - Sair");
            Console.Write("Digite uma opcao: ");            
        }

        public static void mostrarProduto()
        {
            Console.WriteLine("LISTAGEM DE PRODUTOS: ");

            for(int i = 0; i < Program.produtos.Count; i++)
            {
                Console.WriteLine(InvalidProgramException.produtos[i]);
            }
        }

        
    }
}

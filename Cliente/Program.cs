using System;
using System.Globalization;


namespace curso
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.Write("Numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Nome do titular: ");
            string nome = Console.ReadLine();
            Console.Write("Limite de saque: ");
            double limite = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            conta c = new conta (numero, nome, limite);

            Console.WriteLine();
            Console.Write("Informe um valor para deposito: ");
            double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.deposito(valorDeposito);
            Console.WriteLine("Novo saldo = R$" + c.saldo.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.Write("Informe um valor para sacar: ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try
            {
                c.sacar(valorSaque);
                Console.WriteLine("Novo saldo = R$" + c.saldo.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (OperacaoExeption e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }   
}
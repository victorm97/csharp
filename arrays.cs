using System;
using System.Globalization;

namespace Teste
{
    public static class Program
    {
        
        public static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int m = int.Parse(s[0]);
            int n = int.Parse(s[1]);

            int[] mat;

            for(int i = 0; i < m; i++)
            {
                s = Console.ReadLine().Split(' ');
                for(int j = 0; j < n; j++)
                {
                    mat[i,j] = int.Parse(s[j]);
                }
            }

            int x = int.Parse(Console.ReadLine());

            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(mat[i,j] == x)
                    {
                        if(j > 0)
                            Console.WriteLine("Esquerda: " + mat[i, j - 1]);
                        if(i > 0)
                            Console.WriteLine("Acima: " + mat[i - 1, j]);
                        if(j < n - 1)
                            Console.WriteLine("Direita: " + mat[i, j + 1]);
                        if(i < m - 1)
                            Console.WriteLine("Abaixo: " + mat[i + 1, j]);
                    }

                    // solucao palitativa para parar de varrrer a matriz:
                    j = n;
                    i = m;
                }
            }
            
            Console.ReadLine();
        }
    }
}

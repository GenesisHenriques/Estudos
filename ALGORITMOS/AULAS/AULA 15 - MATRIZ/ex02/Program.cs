using System;

namespace ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantas linhas o programa vai ter?");
            int linhas = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas colunas o programa vai ter?");
            int colunas = int.Parse(Console.ReadLine());

            int [,] num = new int [linhas,colunas];
            int par = 0;

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.WriteLine($"Digite o valor [{i},{j}]");
                    num[i,j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Numeros pares na matriz");
            
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    if (num[i,j] % 2 == 0)
                    {
                        Console.Write($"{num[i,j]} ");
                        par++;
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine($"Total de {par} numeros pares: ");
        }
    }
}

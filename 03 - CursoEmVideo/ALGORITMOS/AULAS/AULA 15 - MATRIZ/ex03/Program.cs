using System;

namespace ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantas linhas a matriz deve ter?");
            int linhas = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas colunas a matriz deve ter?");
            int colunas = int.Parse(Console.ReadLine());

            int [,] num = new int[linhas,colunas];

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    if (i == j){
                        num[i,j] = 1;
                    } else {
                        num[i,j] = 0;
                    }
                }
            }
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write($"{num[i,j]} ");
                }
                Console.WriteLine("");
            }
        }
    }
}

using System;

namespace ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] num = new int[4,4];
            int diagonal = 0, produto = 1, maior = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine($"Digite o valor da posição [{i},{j}]");
                    num[i,j] = int.Parse(Console.ReadLine());

                    if (i == j)
                    {
                        diagonal += num[i,j];
                    }
                }
            }
            for (var i = 0; i < 4; i++)
            {
                produto = produto * num[1,i];
            }
            for (var i = 0; i < 4; i++)
            {
                if ( maior < num[i,2])
                {
                    maior = num[i,2];
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"{num[i,j]} ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine($"A soma dos valores da diagonal principal é: {diagonal}");
            Console.WriteLine($"O produto dos valores da segunda linha da matriz é: {produto}");
            Console.WriteLine($"O maior numero digitado da terceira coluna é {maior}");

        }
    }
}

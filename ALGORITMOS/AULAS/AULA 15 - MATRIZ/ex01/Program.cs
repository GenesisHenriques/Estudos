using System;

namespace ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] num = new int[3 , 3];

            for(var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Digite o valor da posição [{i},{j}]:");
                    num[i,j] = int.Parse(Console.ReadLine());
                }
            }
            for(var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    Console.Write($"{num[i,j]} ");
                }
                Console.WriteLine("");
            }

            
        }
    }
}

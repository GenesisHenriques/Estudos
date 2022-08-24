using System;

namespace ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos numeros seram digitados?");
            int max = int.Parse(Console.ReadLine());
            int [] num = new int[max];

            for(var i = 0; i < max; i++)
            {
                Console.WriteLine($"Digite o {i+1}º numero");
                num[i] = int.Parse(Console.ReadLine());
            }
            for(var i = 0; i < max; i++)
            {
                Console.WriteLine($"O {i+1}º numero digite foi {num[i]}.");
            }
        }
    }
}

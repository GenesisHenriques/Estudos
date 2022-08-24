using System;

namespace ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] num = new int [7];

            for(var i = 0; i < 7; i++)
            {
                Console.WriteLine($"Digite o {i+1}º numero");
                num[i] = int.Parse(Console.ReadLine());
            }
            int par = 0;
            for(var i = 0; i < 7; i++)
            {
                if (num[i] % 2 == 0)
                {
                    Console.WriteLine($"O {i+1}º numero digitado, {num[i]}, é par!");
                    par++;
                }
            }
            Console.WriteLine($"O total de numeros pares digitados foi: {par}");
        }
    }
}

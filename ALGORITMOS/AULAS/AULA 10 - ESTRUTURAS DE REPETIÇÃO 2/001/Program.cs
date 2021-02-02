using System;

namespace _001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Qual o numero inicial da contagem?");
            var inicial = int.Parse(Console.ReadLine());

            Console.WriteLine($"Qual o numero final da contagem?");
            var final = int.Parse(Console.ReadLine());

            if (final < inicial)
            {
                Console.WriteLine($"Por favor, digite um numero maior que {inicial}.");
                final = int.Parse(Console.ReadLine());
            }

            var i = inicial;
            while(i < final)
            {

                Console.Write($"{i}...");

                i++;
            }
            Console.Write($"{final}!");
        }
    }
}

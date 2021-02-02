using System;

namespace _004
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fatorial de qual numero você quer ver?");
            var num = int.Parse(Console.ReadLine());
            var fatorial = num;

            for(var i = (num-1); i > 0; i--)
            {
                fatorial = fatorial * i;
            }
            Console.WriteLine($"O fatorial de {num} é: {fatorial}");
        }
    }
}

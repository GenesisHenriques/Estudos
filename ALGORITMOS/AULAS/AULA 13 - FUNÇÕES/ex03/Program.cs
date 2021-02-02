using System;

namespace ex03
{
    class Program
    {
        static void Main(string[] args)
        // fatorial com função
        {
            Console.WriteLine("Fatorial de qual numero você deseja ver?");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine($"O fatorial de {num} é: {fatorial(num)}");
        }
        static int fatorial(int num)
        {
            int fatorial = num;
            for(var i = (num-1); i > 0; i--)
            {
                fatorial = fatorial * i;
            }
            return fatorial;
        }
    }
}

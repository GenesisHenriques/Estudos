using System;

namespace ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            int fim = 0, num = 0;

            while(fim == 0)
            {
                Console.WriteLine("Digite um numero");
                num = int.Parse(Console.ReadLine());

                fim = procesamento(num, fim);
            }
        }

        static int procesamento(int num, int fim)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Digite 0 para finalizar");
            Console.ForegroundColor = ConsoleColor.Gray;
            if (num == 0)
            {
                return fim = 1;
            }
            if(num % 2 == 0)
            {
                Console.WriteLine("");
                Console.WriteLine($"{num} é par");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine($"{num} é impar");
                Console.WriteLine("");
            }
            
            return fim = 0;
        }
    }
}

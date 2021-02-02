using System;

namespace _003
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------Contagem inteligente-------");
            Console.WriteLine("Qual o valor do inicio da contagem?");
            var inicio = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor do final da contagem?");
            var final = int.Parse(Console.ReadLine());

            Console.WriteLine("------------------------------------");
            Console.WriteLine("--------------CONTAGEM--------------");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");

            if (inicio < final)
            {
                for (var i = inicio; i <= final; i++)
                {
                    Console.Write($"{i}...");
                }
            }
            Console.WriteLine("");

            for (var i = inicio; i >= final; i--)
            {
                Console.Write($"{i}...");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("----------------FIM-----------------");
            Console.WriteLine("------------------------------------");
        }
    }
}

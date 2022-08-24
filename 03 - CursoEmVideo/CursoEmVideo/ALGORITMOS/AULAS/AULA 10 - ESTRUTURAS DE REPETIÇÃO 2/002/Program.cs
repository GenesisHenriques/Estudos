using System;

namespace _002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual tabuada você quer ver?");
            var tabuada = int.Parse(Console.ReadLine());

            Console.WriteLine($"!-------tabuada do {tabuada}--------!");
            for(var i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{tabuada}x{i} = {tabuada*i}");
            }
            Console.WriteLine("");
        }
    }
}

using System;

namespace _002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos reais você tem?");
            var real = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor do dolar?");
            var dolar = int.Parse(Console.ReadLine());

            var valor = real / dolar;

            Console.WriteLine($"Com o seu dinheiro atual você consegue {valor} dolares para gastar.");

        }
    }
}

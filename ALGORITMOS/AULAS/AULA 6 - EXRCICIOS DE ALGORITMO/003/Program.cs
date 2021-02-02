using System;

namespace _003
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a temperatura em fahrenheit ");
            decimal fahrenheit  = int.Parse(Console.ReadLine());

            decimal celsius = (fahrenheit - 32) / 1.8M;

            Console.WriteLine($"O equivalente a {fahrenheit}º fahrenheit em celsius é: {celsius}º celsius");



        }
    }
}

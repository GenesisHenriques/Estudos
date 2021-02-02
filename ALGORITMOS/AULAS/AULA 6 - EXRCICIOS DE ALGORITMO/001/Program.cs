using System;

namespace _001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Em que anos você nasceu?");
            var nascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Em que ano estamos?");
            var ano = int.Parse(Console.ReadLine());

            var idade = ano - nascimento; 

            Console.WriteLine($"Você tem, ou fara {idade} anos de idade");
        }
    }
}

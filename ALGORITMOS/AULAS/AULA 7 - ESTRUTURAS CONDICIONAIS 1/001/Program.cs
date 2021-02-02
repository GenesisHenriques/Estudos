using System;

namespace _001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a sua altura?");
            decimal altura = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Qual o seu massa corporia?");
            decimal massa = int.Parse(Console.ReadLine());

            decimal imc = massa / (altura * altura);

            Console.WriteLine($"O seu IMC é: {imc}");
        }
    }
}

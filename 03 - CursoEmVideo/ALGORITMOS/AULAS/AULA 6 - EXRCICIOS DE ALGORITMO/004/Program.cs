using System;

namespace _004
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o total gasto em itens?");
            var gastos = int.Parse(Console.ReadLine());

            var imposto = gastos * 0.6M;
            
            Console.WriteLine($"O tatal de impostos a pagar é: {imposto}");
        }
    }
}

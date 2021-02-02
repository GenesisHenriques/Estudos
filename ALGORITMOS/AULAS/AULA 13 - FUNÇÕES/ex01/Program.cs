using System;

namespace ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero");
            int n2 = int.Parse(Console.ReadLine());

            int soma = Program.soma(n1, n2);
    
            Console.WriteLine($"A soma dos valores é: {soma}");
        }
        static int soma(int n1, int n2)
        {
            return n1 + n2;
        }
    }
}

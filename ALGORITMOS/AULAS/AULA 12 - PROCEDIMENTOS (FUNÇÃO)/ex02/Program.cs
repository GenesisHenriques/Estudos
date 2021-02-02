using System;

namespace ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10, n2 = 7;

            soma(n1, n2);
        }
        
        static void soma(int n1, int n2)
        {
            Console.WriteLine($"Recebi o valor {n1}.");
            Console.WriteLine($"Recebi o valor {n2}.");
            Console.WriteLine($"E a soma de {n1} e {n2} é: {n1 + n2}");
        }
    }
}

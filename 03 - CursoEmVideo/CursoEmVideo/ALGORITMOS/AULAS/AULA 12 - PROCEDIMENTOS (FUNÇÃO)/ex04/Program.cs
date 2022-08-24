using System;

namespace ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3 = 1;

            sequencia(n1, n2, n3);
        }
        static void sequencia(int n1, int n2, int n3)
        {
            Console.Write($"{n1} ");
            Console.Write($"{n2} ");
            for (var i = 0; i < 10; i++)
            {
                Console.Write($"{n3} ");

                n1 = n2;
                n2 = n3;
                n3 = n1 + n2;
            }
        }
    }
}

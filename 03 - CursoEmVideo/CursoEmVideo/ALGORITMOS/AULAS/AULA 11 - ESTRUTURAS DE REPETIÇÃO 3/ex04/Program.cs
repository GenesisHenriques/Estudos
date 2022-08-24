using System;

namespace ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3 = 0;

            n3 = n1 + n2;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(n3);

                n1 = n2;
                n2 = n3;
                n3 = n1 + n2;
            }
                
        }
    }
}

using System;

namespace ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont1 = 3;

            for (var i = 1; i <= cont1; i++)
            {
                for (var j = 1; j <= cont1; j++)
                {
                    for (var k = 1; k <= cont1; k++)
                    {
                        Console.WriteLine($"{i},{j},{k}");
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("");
            }
        }
        
    }
}

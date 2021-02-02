using System;

namespace _006
{
    class Program
    {
        static void Main(string[] args)
        {
            var opcao = 0;

            while(opcao != 3)
            {
                Console.WriteLine("==================");
                Console.WriteLine("=======MENU=======");
                Console.WriteLine("==================");
                Console.WriteLine("| [1] de 1 a 10  |");
                Console.WriteLine("| [2] de 10 a 1  |");
                Console.WriteLine("| [3] sair       |");
                Console.WriteLine("==================");
                opcao = int.Parse(Console.ReadLine());

                if(opcao == 1)
                {
                    for (var i = 0; i < 10; i++)
                    {
                        Console.Write($"{i+1}.. ");
                    }
                    Console.WriteLine("");
                }
                else if (opcao == 2)
                {
                    for (var i = 10; i >= 0; i--)
                    {
                        Console.Write($"{i}.. ");
                    }
                    Console.WriteLine("");
                }
                else
                {
                    opcao = 3;
                }
                
            }
        }
    }
}

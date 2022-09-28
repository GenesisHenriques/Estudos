using System;
using System.Collections.Generic;

namespace _2___exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 5;
            Queue<string> nomes = new Queue<string>();

            while(op != 1)
            {
                Console.Write("FILA = ");
                foreach (var item in nomes)
                {
                    Console.Write($"{item} "); 
                }

                Console.WriteLine("");
                Console.WriteLine("1 - Sair");
                Console.WriteLine("2 - Enfileirar");
                Console.WriteLine("3 - Desenfileirar");
                Console.WriteLine("4 - Primeiro elemento");
                Console.WriteLine("5 - Limpar fila");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1: op = 1; break;
                    case 2: enfileirar(nomes); break;
                    case 3: nomes.Dequeue(); break;
                    case 4: Console.WriteLine($"Primeiro elemento da fila - {nomes.Peek()}"); break;
                    case 5: nomes.Clear(); break;
                    default: Console.WriteLine("EScolha entre 1 e 5"); break;
                }
            }
        }
        public static void enfileirar(Queue<string> nomes)
        {
            Console.WriteLine("Enfileirar");
            var i = Console.ReadLine();
            nomes.Enqueue(i);
        }
    }
}

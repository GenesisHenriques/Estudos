using System;
using System.Collections.Generic; // para a pilha funcionar

namespace _1__exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numeros = new Stack<int>();

            int op = 0;
            while(op != 1)
            {
                Console.Write("Pilha = ");
                foreach(int n in numeros)
                {
                    Console.Write($"{n} ");
                }
                Console.WriteLine("");    

                Console.WriteLine("---------------MENU---------------");
                Console.WriteLine("1 - Sair do programa");
                Console.WriteLine("2 - Verificar se pilha está vazia");
                Console.WriteLine("3 - Empilhar");
                Console.WriteLine("4 - Desempilhar");
                Console.WriteLine("5 - Tamanho da pilha");
                Console.WriteLine("6 - Mostrar topo");
                Console.WriteLine("7 - Limpar pilha");
                Console.WriteLine("----------------------------------");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1: op = 1; break;
                    case 2: verificar(numeros); break;
                    case 3: empilhar(numeros); break;
                    case 4: numeros.Pop(); break;
                    case 5: Console.WriteLine($"pilha com {numeros.Count} elementos."); break;
                    case 6: Console.WriteLine($"Topo da pilha = {numeros.Peek()}"); break;
                    case 7: numeros.Clear(); break;
                        
                    default: Console.WriteLine("Escolha entre as opções acima"); break;
                }
            }
        }
        public static void verificar(Stack<int> numeros)
        {
           Console.Clear();
            if (numeros.Count == 0) // Count = numero de itens na lista
            {
                Console.WriteLine("A pilha está vazia");
            } else {
                Console.WriteLine("Pilha não vazia");
            }
            Console.WriteLine("");
        }
        public static void empilhar(Stack<int> numeros)
        {
            Console.WriteLine("Qual dado você deseja empilhar?");
            int num = int.Parse(Console.ReadLine());
            numeros.Push(num);
        }
        /*
        public static void desempilhar(Stack<int> numeros)
        {
            // string temp = numeros.Pop().ToString(); Quando for string, converter.
            numeros.Pop();
        }
        */

    }
}


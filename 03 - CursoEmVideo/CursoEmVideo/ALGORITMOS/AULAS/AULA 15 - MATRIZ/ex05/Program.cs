using System;

namespace ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] num = new int [4,4];
            int escolha = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    num[i,j] = i+1;
                }
            }

            Console.WriteLine("MENU OPÇÔES");
            Console.WriteLine("[1] Mostrar a Matriz");
            Console.WriteLine("[2] Diagonal Principal");
            Console.WriteLine("[3] Triangulo Superior");
            Console.WriteLine("[4] Triangulo Inferior");
            Console.WriteLine("[5] Sair");
            escolha = int.Parse(Console.ReadLine());
            
            if (escolha == 1)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write($"{num[i,j]} ");
                    }
                    Console.WriteLine("");
                }
            } 
            else if (escolha == 2)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (i == j)
                        {
                            Console.Write($"{num[i,j]} ");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine("");
                }
            } 
            else if (escolha == 3)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (i > j)
                        {
                            Console.Write($"{num[i,j]} ");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine("");
                }
            } 
            else if (escolha == 4)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (i > j)
                        {
                            Console.Write($"{num[i,j]} ");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine("");
                }
            } 
            else if (escolha == 5)
            {
                Console.Write("Obrigado, volte sempre!");
            }  
        }
    }
}

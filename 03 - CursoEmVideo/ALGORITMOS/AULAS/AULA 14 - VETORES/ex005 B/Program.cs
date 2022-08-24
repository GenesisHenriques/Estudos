using System;

namespace ex005_B
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] vetor = new int[10];
            int aux = 0;

            for (int a = 0; a < 10; a++)
            {
                Console.WriteLine($"Digite o {a+1}º numero");
                vetor [a] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < 9; i++)
            {
                for(int j = i+1; j < 10; j++)
                {
                    if (vetor[i] > vetor[j])
                    {
                        aux = vetor[i];
                        vetor[i] = vetor[j];
                        vetor[j] = aux;
                    }
                }
            }
            Console.WriteLine("A ordem crescente dos numeros digitados é:");
            for(var i = 0; i < 10; i++)
            {
                Console.Write($"{vetor[i]} ");
            }
        }
    }
}

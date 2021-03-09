using System;

namespace ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] vetor = new int [10]{8,7,9,4,2,3,1,6,5,0};

            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = i;
            }

            shellSort(vetor);
            for (int i = 0; i < vetor.Length; i++)
            {
               Console.WriteLine($"{vetor[i]} "); 
            }
        }
        /*
        static void mostrarVetor(int [] numeros)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
               Console.WriteLine($"{numeros[i]} "); 
            }
        }
        */

        // É um método de ordenação por inserção criado por Donald Shell que basicamente divide a lista a ser ordenada em grupos menores e aplica o método de ordenação por inserção.
        public static int[] shellSort(int[] vetor)
        {
            int h = 1;
            int n = vetor.Length;
            
            while (h < n)
            {
                h = h * 3 + 1;
            }

            h = h / 3;
            int c, j;
            while (h > 0)
            {
                for (int i = h; i < n; i++)
                {
                    c = vetor[i];
                    j = i;
                    while (j >= h && vetor[j - h] > c)
                    {
                        vetor[j] = vetor[j - h];
                        j = j - h;
                    }
                    vetor[j] = c;
                }
                h = h / 2;
            }
            return vetor;
        }


    }
}

using System;

namespace ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 10;
            int [] vetor = new int [10]{8,7,9,4,2,3,1,6,5,0};

            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = i;
            }

            insertionSort(vetor);
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

        // O Insertion Sort ou Ordenação por inserção é um método simples de ordenação que percorre um vetor ordenando os elementos a esquerda a medida que avança. Vamos ao exemplo em C#.
        public static int[] insertionSort(int[] vetor)
        {
            int i, j, atual;
            for (i = 1; i < vetor.Length; i++)
            {
                atual = vetor[i];
                j = i;
                while ((j > 0) && (vetor[j - 1] > atual))
                {
                    vetor[j] = vetor[j - 1];
                    j = j - 1;
                }
                vetor[j] = atual;
            }
            for (i = 0; i < vetor.Length; i++)
            {
               Console.WriteLine($"{vetor[i]} "); 
            }
            return vetor;
        }


    }
}

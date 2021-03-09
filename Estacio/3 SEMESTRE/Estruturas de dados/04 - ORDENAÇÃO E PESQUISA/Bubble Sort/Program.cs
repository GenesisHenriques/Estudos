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

            bubbleSort(vetor);
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
        public static int[] bubbleSort(int[] vetor)
        {
            int tamanho = vetor.Length;
            int comparacoes = 0;
            int trocas = 0;

            for (int i = tamanho - 1; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    comparacoes++;
                    if (vetor[j] > vetor[j + 1])
                    {
                        int aux = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = aux;
                        trocas++;
                    }
                }
            }

            return vetor;
        }


    }
}

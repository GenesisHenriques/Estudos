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

            selectionSort(vetor);

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

        // O Selection Sort é um método de ordenação por seleção. Ele percorre a lista em busca do menor valor e o move para a posição correta precedido sempre do elemento de menor valor.
        public static int[] selectionSort(int[] vetor)
        {
            int min, aux;

            for (int i = 0; i < vetor.Length - 1; i++)
            {
                min = i;

                for (int j = i + 1; j < vetor.Length; j++)
                    if (vetor[j] < vetor[min])
                        min = j;

                if (min != i)
                {
                    aux = vetor[min];
                    vetor[min] = vetor[i];
                    vetor[i] = aux;
                }
            }
            return vetor;
        }


    }
}

using System;

namespace _1__exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] vetor = new int [10] {0,0,0,0,0,0,0,0,0,0};
            string finalizar = "N";
            while(finalizar == "N")
            {
                Console.WriteLine("");
                Console.WriteLine("LISTA ATUAL");
                Exibir(vetor);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Reiniciar lista.............1");
                Console.WriteLine("Inserir idade na lista......2");
                Console.WriteLine("Exibir lista................3");
                Console.WriteLine("Ordenar lista...............4");
                Console.WriteLine("Exibir frequencia...........5");
                int op = int.Parse(Console.ReadLine());

                if (op == 1)
                {
                    Reiniciar(vetor);
                } else if (op == 2){
                    InserirIdade(vetor);
                } else if (op == 3){
                    Exibir(vetor);
                } else if (op == 4){
                    OrdenarLista(vetor);
                } else if (op == 5){
                    ExibirFrequencia(vetor);
                } else {
                    Console.WriteLine("Por favor, Escolha entre as opções possiveis");
                }
                Console.WriteLine("");
                Console.WriteLine("Deseja finalizar? S/N");
                finalizar = Console.ReadLine();
            }
        }

        public static int[] Reiniciar(int [] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"Digite o valor do {i+1}º elemento da lista");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            return vetor;
        }
        public static int[] InserirIdade(int [] vetor)
        {
            Console.WriteLine("Em qual elemento você deseja inserir um numero?");
            int inserir = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual numero você deseja inserir?");
            int num = int.Parse(Console.ReadLine());
            vetor[inserir - 1] = num;
            return vetor;
        }
        public static void Exibir(int [] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"{vetor[i]}, ");
            }
        }
        public static int[] OrdenarLista(int [] vetor)
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
        public static int[] ExibirFrequencia(int [] vetor)
        {
            return vetor;
        }
    }
}

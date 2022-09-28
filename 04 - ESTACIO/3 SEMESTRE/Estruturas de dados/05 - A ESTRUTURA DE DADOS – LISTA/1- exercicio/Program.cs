using System;

namespace _1__exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] vetor = new int [10];
            int op = 1;
            while(op != 0)
            {
                Console.WriteLine("");
                Console.WriteLine("LISTA ATUAL");
                Exibir(vetor);
                Console.WriteLine("");
                Console.WriteLine("");
                mensagem("Sair..........................0");
                mensagem("Reiniciar lista...............1");
                mensagem("Inserir idade na lista........2");
                mensagem("Exibir lista..................3");
                mensagem("Exibir tamanho da lisa........4");
                mensagem("Exibir um elemento da lista...5");
                op = int.Parse(Console.ReadLine());

                if (op == 1)
                {
                    Reiniciar(vetor);
                } else if (op == 2){
                    InserirIdade(vetor);
                } else if (op == 3){
                    Exibir(vetor);
                } else if (op == 4){
                    Console.WriteLine($"A lista tem {vetor.Length} elementos");
                } else if (op == 5){
                    ExibirIndice(vetor);
                } else if (op > 5){
                    Console.WriteLine("Por favor, Escolha entre as opções possiveis");
                }
                Console.WriteLine("");
            }
        }
        public static void mensagem(string mensagem)
        {
            Console.WriteLine($"{mensagem}");
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
        public static void ExibirIndice(int [] vetor)
        {
            Console.WriteLine("Qual o indice do elemento?");
            int ind = int.Parse(Console.ReadLine());

            Console.WriteLine($"{vetor[ind]}");
        }
    }
}

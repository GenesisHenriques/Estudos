using System;

namespace _2___exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 10, op = 1;
            int [] vetor = new int [max];

            while(op != 0)
            {
                Mensagem("Sair..................0");
                Mensagem("Inserir...............1");
                Mensagem("Exibir................2");
                Mensagem("Remover...............3");
                op = int.Parse(Console.ReadLine());

                switch(op)
                {
                    case 0: op = 0; break;
                    case 1: Inserir(vetor); break;
                    case 2: Exibir(vetor); break;
                    case 3: Remover(vetor); break;
                    default: Console.WriteLine("Escolha entre as opções abaixo"); break;
                }
            }
        }
        public static void Mensagem (string mensagem)
        {
            Console.WriteLine($"{mensagem}");
        }

        //ESCOLHAS--\/--
        public static int [] Inserir (int [] vetor)
        {
            Console.WriteLine("Inserir em qual casa?");
            int inserir = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserir qual numero?");
            int num = int.Parse(Console.ReadLine());

            vetor[inserir] = num;
            return vetor;
        }
        public static void  Exibir (int [] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"{vetor[i]}, ");
            }
            Console.WriteLine("");
        }
        public static int [] Remover (int [] vetor)
        {
            Console.WriteLine("Remover o elemento de qual casa?");
            int remover = int.Parse(Console.ReadLine());

            vetor[remover] = 0;
            return vetor;
        }
    }
}

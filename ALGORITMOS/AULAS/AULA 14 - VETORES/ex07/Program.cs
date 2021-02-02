using System;

namespace ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] gabarito = new string [5];
            string [] respostas = new string [5];
            int [] nota = new int [5];
            string [] nome = new string [3];
            int notaTotal = 0;

            Console.WriteLine("Qual o gabarito da prova?");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Questão {i+1}");
                gabarito [i] = (Console.ReadLine());
            }
            Console.Clear();
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine($"-----Aluno {i+1}-----");
                Console.WriteLine("Nome:");
                nome[i] = Console.ReadLine();

                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine($"Questão {j+1}: ");
                    respostas[j] = (Console.ReadLine());

                    if(respostas[j] == gabarito[j])
                    {
                        nota[i] = nota[i] + 2;
                    }
                }
                notaTotal += nota[i];
                Console.Clear();
            }
            Console.WriteLine("NOTAL FINAL");
            Console.WriteLine("-----------------");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{nome[i]} nota: {nota[i]}");
            }
            Console.WriteLine($"");
            Console.WriteLine($"Media da turma {notaTotal/3}");
            Console.WriteLine($"");



        }
    }
}

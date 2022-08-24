using System;

namespace ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos alunos tem a turma?");
            int max = int.Parse(Console.ReadLine());
            Console.Clear();

            int [] notaUm = new int[max];
            int [] notaDois = new int[max];
            int [] media = new int[max];
            string [] nome = new string[max];

            for (var i = 0; i < max; i++)
            {
                Console.WriteLine($"Qual o nome do {i+1}º aluno?");
                nome[i] = Console.ReadLine();

                Console.WriteLine($"Nota da 1º prova");
                notaUm[i] = int.Parse(Console.ReadLine());

                Console.WriteLine($"Nota da 2º prova");
                notaDois[i] = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            for(var i = 0; i < max; i++)
            {
                media[i] = (notaUm[i] + notaDois[i]) / 2;
                Console.Write($"{nome[i]}: {media[i]}");
                if(media[i] >= 7)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" - Aprovado");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" - Reprovado");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                Console.WriteLine("");
            }
        }
    }
}

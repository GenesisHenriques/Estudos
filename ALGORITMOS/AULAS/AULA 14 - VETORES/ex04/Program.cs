using System;

namespace ex04
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
            int mediaTotal = 0, notaTotal = 0;

            for (var i = 0; i < max; i++)
            {
                Console.WriteLine($"Qual o nome do {i+1}º aluno?");
                nome[i] = Console.ReadLine();

                Console.WriteLine($"Nota da 1º prova");
                notaUm[i] = int.Parse(Console.ReadLine());

                Console.WriteLine($"Nota da 2º prova");
                notaDois[i] = int.Parse(Console.ReadLine());
                Console.Clear();

                media[i] = (notaUm[i] + notaDois[i]) / 2;
                notaTotal += media[i];
            }
            mediaTotal = notaTotal / max;

            Console.WriteLine($"Media da turma: {mediaTotal}");

            for(var i = 0; i < max; i++)
            {
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

                if(media[i] > mediaTotal)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($" - nota acima da media da turma");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                Console.WriteLine("");
                
            }
        }
    }
}

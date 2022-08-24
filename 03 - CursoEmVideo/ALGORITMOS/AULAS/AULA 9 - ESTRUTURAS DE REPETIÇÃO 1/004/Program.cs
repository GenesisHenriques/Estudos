using System;

namespace _004
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos alunos a turma tem?");
            var max = int.Parse(Console.ReadLine());

            int [] nota = new int [max];
            string [] nome = new string [max];
            int maior = 0, aluno = 0;

            for (var i = 0; i < max; i++)
            {
                Console.WriteLine($"Qual o nome do {i+1}º aluno?");
                nome [i] = Console.ReadLine();

                Console.WriteLine($"Qual a nota do {i+1}º aluno?");
                nota [i] = int.Parse(Console.ReadLine());

                if (maior < nota[i])
                {
                    maior = nota [i];
                    aluno = i;
                }
            }
            Console.WriteLine($"A maior nota foi do aluno {nome[aluno]}, que tirou {nota[aluno]} pontos.");
        }
    }
}

using System;

namespace ex
{
    class Program
    {
        struct Cadastro {
            public string nome;
            public int idade;
            public int turma;

            public int soma(int idade, int turma){
                return idade + turma;
            }
        }

        static void Main(string[] args)
        {
            int max = 3;
            Cadastro [] alunos = new Cadastro [max];

            for (var i = 0; i < max; i++)
            {
                Console.WriteLine($"Qual o nome do {i+1}° aluno?");
                alunos[i].nome = Console.ReadLine();
                Console.WriteLine("E qual a idade do aluno?");
                alunos[i].idade = int.Parse(Console.ReadLine());
                Console.WriteLine($"Qual a turma de {alunos[i].nome}?");
                alunos[i].turma = int.Parse(Console.ReadLine());
            }
            for (var i = 0; i < max; i++)
            {
                Console.WriteLine($"{alunos[i].nome}, de {alunos[i].idade} anos - TURMA {alunos[i].turma}");
                Console.WriteLine(alunos[i].soma(alunos[i].idade, alunos[i].turma));
            }
        }
    }
}

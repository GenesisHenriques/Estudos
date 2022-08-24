using System;

namespace _001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor da 1° nota");
            decimal notaUm = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da 2° nota");
            decimal notaDois = int.Parse(Console.ReadLine());

            decimal media = (notaUm + notaDois) / 2;

            if (media < 5)
            {
                Console.WriteLine($"A nota do aluno foi {media} ele está reprovado!");
            }
            else if ( media >= 5 && media <7)
            {
                Console.WriteLine($"A nota do aluno foi {media} ele está de recuperação");
            }
            else 
            {
                Console.WriteLine($"A nota do aluno foi {media} ele está aprovado");
            }
        }
    }
}

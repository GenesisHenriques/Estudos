using System;

namespace ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos numeros seram digitados?");
            var max = int.Parse(Console.ReadLine());

            int num = 0, soma = 0, divCinco = 0, nulo = 0, pares = 0;

            for (var i = 0; i < max; i++)
            {
                Console.WriteLine($"Digite o {i+1}º numero.");
                num = int.Parse(Console.ReadLine());

                soma = soma + num;

                if (num % 5 == 0 && num > 0)
                {
                    divCinco++;
                }
                if (num == 0)
                {
                    nulo++;
                }
                if (num % 2 == 0)
                {
                    pares = pares + num;
                }
            }
            
            var media = soma / max;

            Console.WriteLine($"A soma dos valores digitados foi: {soma}");
            Console.WriteLine($"A media entre os valores digitados foi: {media}");
            Console.WriteLine($"Numeros divisiveis por 5: {divCinco}");
            Console.WriteLine($"O total de numeros nulos digitados foi: {nulo}");
            Console.WriteLine($"A soma dos numeros pares digitados foi: {pares}");
        }
    }
}

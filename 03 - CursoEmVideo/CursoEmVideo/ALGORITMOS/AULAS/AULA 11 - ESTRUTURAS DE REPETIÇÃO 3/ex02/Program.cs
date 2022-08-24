using System;

namespace ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos numeros seram digitados?");
            var max = int.Parse(Console.ReadLine());

            int cont = 0, soma = 0;

            for (var i = 0; i < max; i++)
            {
                Console.WriteLine($"Digite o {i+1}º numero");
                var num = int.Parse(Console.ReadLine());

                if (num > -1 && num < 11)
                {
                    cont++;
                }
                if (num % 2 == 1)
                {
                    soma = soma + num;
                }
            }

            Console.WriteLine($"Dentre os {max} numeros digitados, {cont} estão entre 0 e 10.");
            Console.WriteLine($"E a soma dos valores impares digitados é: {soma}");
        }
    }
}

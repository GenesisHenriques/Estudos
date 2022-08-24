using System;

namespace _005
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o valor do emprestimo?");
            var valor = int.Parse(Console.ReadLine());

            Console.WriteLine("Em quantas parcelas você quer pagar o emprestimo?");
            var parcela = int.Parse(Console.ReadLine());

            Console.WriteLine($"O valor do juros é de {valor * 0.2M}");
            Console.WriteLine($"Portanto o valor total a ser pago é de {valor + (valor*0.2M)}");
            Console.WriteLine($"Divido em {parcela}x de {(valor + (valor*0.2M)) / 12}");
        }
    }
}

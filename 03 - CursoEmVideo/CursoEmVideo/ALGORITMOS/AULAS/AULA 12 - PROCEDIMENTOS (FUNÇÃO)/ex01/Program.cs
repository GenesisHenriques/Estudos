using System;

namespace ex01
{
    class Program
    {
        static void Topo (string maiornome, int maior)
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("--------------DETECTOR DE PESO-------------");
            Console.WriteLine($"Maior peso até agora: {maiornome}, {maior} kilos");
            Console.WriteLine("-------------------------------------------");
        }

        static void Main(string[] args)
        {
            int maior = 0, peso = 0;
            string nome = "", maiornome = "";

            Topo(maiornome , maior);

            Console.WriteLine("Quantos numeros seram digitados?");
            var max = int.Parse(Console.ReadLine());

            for (var i = 0; i < max; i++)
            {
                Console.WriteLine($"Qual o nome da {i+1}º pessoa?");
                nome = Console.ReadLine();
                Console.WriteLine($"E qual o seu peso?");
                peso = int.Parse(Console.ReadLine());

                if (maior < peso)
                {
                    maior = peso;
                    maiornome = nome;
                    Topo(maiornome , maior);
                }
                Topo(maiornome , maior);
            }
            Console.WriteLine($"A pessoa com o maior peso é: {maiornome}, com {peso} kilos");
        }
        
    }
}

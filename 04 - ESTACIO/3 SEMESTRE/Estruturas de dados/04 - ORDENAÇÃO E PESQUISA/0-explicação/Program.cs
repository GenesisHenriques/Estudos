using System;

namespace ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int tam = 10, op = 0;
            int [] lista = new int[tam];

            for (int i = 0; i < tam; i++)
            {
                lista[i] = i+1;
            }
            Console.WriteLine("Exibir os elementos da lista....1");
            Console.WriteLine("Exibir um elemento da lista.....2");
            Console.WriteLine("Exibir o tamanho da lista.......3");
            op = int.Parse(Console.ReadLine());
            if (op == 1)
            {
                for (int i = 0; i < lista.Length; i++)
                {
                    Console.Write($"{lista[i]}, ");
                }
            } 
            else if (op == 2)
            {
                Console.WriteLine("Qual elemento você deseja ver?");
                int elemento = int.Parse(Console.ReadLine());

                if (elemento > tam || elemento < 0)
                {
                    Console.WriteLine($"Não existe esse elemento na lista, escolha um numero entre ) e {tam}");
                } else 
                {
                    Console.WriteLine($"{lista[elemento]}");
                }
            } 
            else if (op == 3)
            {
                Console.WriteLine($"A lista tem {tam} elementos");
            } 
            else
            {
                Console.WriteLine("Por favor, escolha entre as opções acima");
            }
        }
    }
}

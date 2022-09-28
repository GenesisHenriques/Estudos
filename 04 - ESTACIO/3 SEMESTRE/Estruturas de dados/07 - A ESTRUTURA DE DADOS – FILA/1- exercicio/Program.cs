using System;
using System.Collections.Generic; // para a FILA funcionar

namespace _1__exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int [] num = {10,20,30,40,50};
            Queue<int> numeros = new Queue<int>(num);
            */

            Queue<string> veiculos = new Queue<string>();

            veiculos.Enqueue("Carro");
            veiculos.Enqueue("Moto");
            veiculos.Enqueue("Navio");
            veiculos.Enqueue("Avião");
            
            Console.WriteLine($"Tamanho da fila = {veiculos.Count}");

            if (veiculos.Contains("Genesis")){
                Console.WriteLine("Sim");
            } else {
                Console.WriteLine("Não");
            }

            
        }
    }
}


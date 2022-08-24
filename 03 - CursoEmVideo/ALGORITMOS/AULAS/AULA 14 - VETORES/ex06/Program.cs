using System;

namespace ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] time = new string[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Qual o nome do {i+1}º time?");
                time[i] = Console.ReadLine();
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = i+1; j < 3; j++)
                {
                    Console.WriteLine($"{time[i]} vs {time[j]}");
                }
            }
        }
    }
}

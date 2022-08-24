using System;

namespace ex08
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] cadeira = new string[10];
            string continuar = "S";
            int num = 0;

            for (int i = 0; i < 10; i++)
            {
                cadeira[i] = $"B{i+1}";
            }
            Console.WriteLine("");

            // ^ Criei a tabela ^

            while (continuar == "S")
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write($"[{cadeira[i]}] ");
                }
                Console.WriteLine("");

                Console.Write("Reservar a cedeira B:");
                num = int.Parse(Console.ReadLine());
                if (cadeira[num - 1] == "--")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERRO: Lugar ocupado!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                cadeira[num - 1] = "--";
                
                Console.WriteLine("Quer reservar outra cadeira? [S/N]");
                continuar = Console.ReadLine();
                Console.Clear();
            }
        }
    }
}

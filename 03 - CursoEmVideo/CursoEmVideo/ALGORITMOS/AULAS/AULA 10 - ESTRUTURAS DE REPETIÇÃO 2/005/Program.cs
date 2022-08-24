using System;

namespace _005
{
    class Program
    {
        static void Main(string[] args)
        {
           string continuar = "S";

           while(continuar == "S")
           {
               Console.WriteLine("Fatorial de qual numero você quer ver?");
                var num = int.Parse(Console.ReadLine());
                var fatorial = num;

                for(var i = (num-1); i > 0; i--)
                {
                    fatorial = fatorial * i;
                }
                Console.WriteLine($"O fatorial de {num} é: {fatorial}");

                Console.WriteLine("Deseja ver o fatorial de outro numero? [S/N]");
                continuar = Console.ReadLine();

                if(continuar != "S" || continuar != "N")
                {
                    Console.WriteLine("Por favor, digite S ou N");
                    continuar = Console.ReadLine();
                }
           }
            Console.WriteLine("FIM!!");
        }
    }
}

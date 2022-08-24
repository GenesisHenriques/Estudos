using System;

namespace _003
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos numeros você vai digitar?");
            var max = int.Parse(Console.ReadLine());

            int [] num = new int[max];
            int negativos = 0;
            string numNegativos = "";

            for (var i = 0; i < max; i++)
            {
                Console.WriteLine($"Digite o {i+1}° numero");
                num[i] = int.Parse(Console.ReadLine());

                if(num[i] < 0)
                {
                    negativos++;
                    numNegativos = numNegativos + " " + num[i];
                }
            }

            Console.WriteLine($"Dentre os numeros digitados, {negativos} foram negativos.");
            Console.WriteLine($"E os numeros negativos digitados foram: {numNegativos}");
        }
    }
}

using System;

namespace ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero");
            int num = int.Parse(Console.ReadLine());

            string a = Program.imparOuPar(num);
            Console.WriteLine(a);


        }
        static string imparOuPar(int num)
        {
            if (num % 2 == 0)
            {
                return "par";
            }
            else
            {
                return "impar";
            }
        }
    }
}

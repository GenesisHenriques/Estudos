using System;

namespace _002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu peso?");
            float peso = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual a sua altura?");
            float altura = float.Parse(Console.ReadLine());

            float imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                Console.WriteLine($"Seu imc é {imc}, você está abaixo do peso");
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                Console.WriteLine($"Seu imc é {imc}, você está no peso normal");
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                Console.WriteLine($"Seu imc é {imc}, você está com sobrepeso");
            }
            else if (imc >= 30 && imc <= 34.9)
            {
                Console.WriteLine($"Seu imc é {imc}, você está com obesidade grau 1 ");
            }
            else if (imc >= 35 && imc <= 39.9)
            {
                Console.WriteLine($"Seu imc é {imc}, você está com obesidade grau 2");
            }
            else 
            {
                Console.WriteLine($"Seu imc é {imc}, você está com obesidade grau 3 (mórbita)");
            }
        }
    }
}

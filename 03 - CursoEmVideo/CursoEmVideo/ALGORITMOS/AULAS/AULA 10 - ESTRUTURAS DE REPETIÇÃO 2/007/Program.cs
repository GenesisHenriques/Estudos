using System;

namespace _007
{
    class Program
    {
        static void Main(string[] args)
        {
            string continuar = "S", sexo = "";
            int idade = 0, cabelo = 0, contMasc = 0, contFem = 0;

            while (continuar == "S")
            {
                Console.WriteLine("Qual o seu sexo?");
                Console.WriteLine("[M] para masculino");
                Console.WriteLine("[F] para feminino");
                sexo = Console.ReadLine();

                Console.WriteLine("E qual a sua idade?");
                idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Por fim, qual a cor do seu cabelo?");
                Console.WriteLine("[1] Preto");
                Console.WriteLine("[2] Castanho");
                Console.WriteLine("[3] Loiro");
                Console.WriteLine("[4] Ruivo");
                cabelo = int.Parse(Console.ReadLine());

                if (sexo == "M" && idade > 18 && cabelo == 2)
                {
                    contMasc++;
                }
                else if (sexo == "F" && idade >= 25 && idade <= 30 && cabelo == 3)
                {
                    contFem++;
                }
               Console.WriteLine("Deseja continuar?"); 
               Console.WriteLine("[S] sim");
               Console.WriteLine("[N] não");
               continuar = Console.ReadLine();
            }
            if (contFem == 0 || contMasc == 0)
            {
                Console.WriteLine("Não foi possivel encontrar pessoas de acordo com o perfil");
            }
            else if (contFem > 0 || contMasc > 0)
            {
                Console.WriteLine($"O total de homens com mais de 18 anos e cabelo castanho nessa pesquisa foi: {contMasc}.");
                Console.WriteLine($"O total de mulherer com idade entre 25 e 30 anos e cabelo loiro nessa pesquisa foi: {contFem}.");
            }
            
        }
    }
}

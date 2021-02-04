using System;

namespace ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            string [,] num = new string [3,3];
            int q = 0, escolha, continuar = 0;
            string a = "";

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    num[i,j] = $"{1 + q++}";
                }
            }
            Jogo(num);

            while (continuar == 0) // As escolhas do cliente 
            {
                Console.WriteLine($"Vai jogar 'X' em qual posição?");
                escolha = int.Parse(Console.ReadLine());
                a = "X";
                Escolha(escolha, a,num);
                Jogo(num);
                
                Console.WriteLine($"Vai jogar 'O' em qual posição?");
                escolha = int.Parse(Console.ReadLine());
                a = "O";
                Escolha(escolha, a,num);
                Jogo(num);
            }
            continuar = 0;

            
            
            
        }
        static void Jogo(string [,] num) // Parte do codigo que cria a tabela
        {
            Console.Clear();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"+----+----+----+");
                for (int j = 0; j < 1; j++)
                {
                    Console.WriteLine($"+ {num[i,j]}  + {num[i,j+1]}  + {num[i,j+2]}  + ");
                }
            }
            Console.WriteLine($"+----+----+----+");
        }
        static void Escolha (int escolha, string a, string [,] num)// verifica a escolha  do cliente 
        {
            if(escolha == 1)
            {
                if (num [0,0] == "X" || num [0,0] == "O")
                {
                    Console.WriteLine("[ERRo] escolha outro numero");
                }
                num[0,0] = $"{a}";
            } 
            else if (escolha == 2)
            {
                num[0,1] = $"{a}";
            }
            else if (escolha == 3)
            {
                num[0,2] = $"{a}";
            }
            else if(escolha == 4)
            {
                num[1,0] = $"{a}";
            } 
            else if (escolha == 5)
            {
                num[1,1] = $"{a}";
            }
            else if (escolha == 6)
            {
                num[1,2] = $"{a}";
            }
            else if(escolha == 7)
            {
                num[2,0] = $"{a}";
            } 
            else if (escolha == 8)
            {
                num[2,1] = $"{a}";
            }
            else if (escolha == 9)
            {
                num[2,2] = $"{a}";
            }

        }
    }
}

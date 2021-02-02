using System;

namespace ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] num = new int[4];
            int a = 0;

            for (var i = 0; i < 4; i++)
            {
                Console.WriteLine($"Digite o {i+1}º numero");
                num[i] = int.Parse(Console.ReadLine());
            }

            for(var i = 0; i < 4; i++)
            {
                if(num[1] < num[i+1])
                {
                    a = num[1];
                    num[1] = num[i+1];
                    num[i+1] = a;
                }

                for (var j = 2; j < 4; j++)
                {
                    if(num[2] < num[j+1])
                    {
                        a = num[2];
                        num[2] = num[j+1];
                        num[j+1] = a;
                    }

                    for (int k = 3; k < 4; k++)
                    {
                        if(num[3] < num[k+1])
                        {
                            a = num[3];
                            num[3] = num[k+1];
                            num[k+1] = a;
                        }
                    }
                }
            }
            for (int i = 0; i < 4; i++)
            {
               Console.Write($"{num[i]}, ");
            }
            Console.Write($". ");

        }
    }
}

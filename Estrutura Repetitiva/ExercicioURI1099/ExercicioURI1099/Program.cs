using System;

namespace URI1099
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y, N, min, max, soma;
            string[] vet;
            soma = 0;


            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                vet = Console.ReadLine().Split(' ');
                X = int.Parse(vet[0]);
                Y = int.Parse(vet[1]);

                if (X < Y)
                {
                    min = X;
                    max = Y;
                }
                else
                {
                    min = Y;
                    max = X;
                }
                
                min += 1;

                while (min < max)
                {

                    if (min % 2 == 1)
                    {
                        soma = soma + min;

                    }

                    min += 1;
                    
                }

                Console.WriteLine(soma);
                
            }

        }
    }
}
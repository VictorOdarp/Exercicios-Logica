using System;

namespace URI1150
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y, N, soma, cont;
            string[] vet;

            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {

                vet = Console.ReadLine().Split(' ');
                X = int.Parse(vet[0]);
                Y = int.Parse(vet[1]);
                soma = 0;
                cont = 0;

                while (cont < Y)
                {
                    if (X % 2 != 0)
                    {
                        soma = soma + X;
                        cont++;

                    }

                    X += 1;
                   
                }
                
                Console.WriteLine(soma);


            }

            


        }
    }
}

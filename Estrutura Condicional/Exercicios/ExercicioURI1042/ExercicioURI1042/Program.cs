using System;
using System.ComponentModel.Design;

namespace URI1042
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1, N2, N3, Primeiro, Segundo, Terceiro;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            N1 = int.Parse(vet[0]);
            N2 = int.Parse(vet[1]);
            N3 = int.Parse(vet[2]);

            if (N1 < N2 && N1 < N3)
            {
                Primeiro = N1;
                if (N2 < N3)
                {
                    Segundo = N2;
                    Terceiro = N3;

                }
                else
                {
                    Segundo = N3;
                    Terceiro = N2;

                }
            }
            else if (N2 < N3)
            {
                Primeiro = N2;
                if (N1 < N3)
                {
                    Segundo = N1;
                    Terceiro = N3;
                }
                else
                {
                    Segundo = N3;
                    Terceiro = N1;
                }
            }
            else if (N2 < N1)
            {
                Primeiro = N3;
                Segundo = N2;
                Terceiro = N1;
            }
            else
            {
                Primeiro = N3;
                Segundo = N1;
                Terceiro = N2;
            }

            Console.WriteLine(Primeiro);
            Console.WriteLine(Segundo);
            Console.WriteLine(Terceiro + "\n");

            Console.WriteLine(N1);
            Console.WriteLine(N2);
            Console.WriteLine(N3);
        }   
    }
}
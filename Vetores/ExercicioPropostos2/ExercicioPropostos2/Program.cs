using System;

namespace ExercicioPropostos2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int[] X;
            string[] vet;
            int Cont;


            N = int.Parse(Console.ReadLine());
            X = new int[N];

            vet = Console.ReadLine().Split(' ');

            for (int i = 0;  i < N; i++)
            {
                 X[i] = int.Parse(vet[i]);
            }

            Cont = 0;

            for (int i = 0; i < N; i++)
            {
                if (X[i] % 2 == 0)
                {
                    Console.Write(X[i] + " ");
                    Cont++;
                }
            }
            
            Console.WriteLine();
            Console.WriteLine(Cont);


        }
    }
}

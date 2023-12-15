using System;
using System.Globalization;

namespace ExercicioProposto5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int[] X;
            string[] vet;

            N = int.Parse(Console.ReadLine());
            X = new int[N];

            vet = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                X[i] = int.Parse(vet[i]);
            }

            int soma = 0;
            int Cont = 0;

            for (int i = 0; i < N; i++)
            {
                if (X[i] % 2 == 0)
                {
                    soma = X[i] + soma;
                    Cont++;
                }
            }

            double média = 0.0;
            média = (double) soma / Cont;

            Console.WriteLine(média.ToString("F1"), CultureInfo.InvariantCulture);
        }
    }
}

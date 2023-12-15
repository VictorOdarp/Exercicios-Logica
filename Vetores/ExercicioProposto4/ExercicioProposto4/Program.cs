using System;
using System.Globalization;


namespace ExercicioProposto4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double[] X;
            string[] vet;

            N = int.Parse(Console.ReadLine());
            X = new double[N];

            vet = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                X[i] = double.Parse(vet[i], CultureInfo.InvariantCulture);
            }

            double soma = 0.0; 

            for (int i = 0; i < N; i++)
            {
               soma = soma + X[i];
            }

            double média = 0.0;
            média = soma / N;
            Console.WriteLine(média.ToString("F3"), CultureInfo.InvariantCulture);

            for (int i = 0; i < N; i++)
            {
                if (X[i] < média)
                {
                    Console.WriteLine(X[i].ToString("F1"), CultureInfo.InvariantCulture);
                }
            }
        }
    }
}
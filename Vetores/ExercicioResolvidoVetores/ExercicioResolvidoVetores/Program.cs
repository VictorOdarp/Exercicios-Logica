using System;
using System.Globalization;

namespace ExercicioVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double[] X;
            
            
            N = int.Parse(Console.ReadLine());
            X = new double[N];

            for (int i = 0; i < N; i++)
            {
                X[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(X[i].ToString("F1"), CultureInfo.InvariantCulture);
            }
        }
    }
}
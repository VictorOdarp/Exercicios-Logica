using System;
using System.Globalization;

namespace ExercicioResolvido3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double[] X;
            string[] vet;
            double soma, média;

            N = int.Parse(Console.ReadLine());
            X = new double[N];

            vet = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                X[i] = double.Parse(vet[i], CultureInfo.InvariantCulture);
            }

            soma = 0;
            
            for (int i = 0; i < N; i++)
            {
                Console.Write(X[i].ToString("F1") + " ", CultureInfo.InvariantCulture);
                soma = X[i] + soma;

            }
           
            média = 0;
            média = soma / N;

            Console.Write("\n");
            Console.WriteLine(soma.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine(média.ToString("F2"), CultureInfo.InvariantCulture); 

           

        }
    }
}

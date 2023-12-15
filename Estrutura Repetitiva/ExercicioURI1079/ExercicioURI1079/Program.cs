using System;
using System.Globalization;


namespace URI1079
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double N1, N2, N3, média;
            string[] vet;

            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                vet = Console.ReadLine().Split(' ');
                N1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                N2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                N3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

                média = ((N1 * 2) + (N2 * 3) + (N3 * 5)) / 10;
                Console.WriteLine(média.ToString("F1"), CultureInfo.InvariantCulture);

            }

            
        }
    }
}

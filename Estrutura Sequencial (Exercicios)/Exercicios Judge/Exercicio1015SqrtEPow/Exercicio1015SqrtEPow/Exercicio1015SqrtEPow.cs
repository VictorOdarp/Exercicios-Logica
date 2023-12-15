using System;
using System.Globalization;



namespace Exercicio10Judge
{
    class Program
    {

        static void Main(string[] args)
        {
            double X1, Y1, X2, Y2, Distancia;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            X1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            Y1 = double.Parse(vet[1], CultureInfo.InvariantCulture);
            vet = Console.ReadLine().Split(' ');
            X2 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            Y2 = double.Parse(vet[1], CultureInfo.InvariantCulture);

            Distancia = Math.Sqrt(Math.Pow(X2 - X1, 2.0) + Math.Pow(Y2 - Y1, 2.0));

            Console.WriteLine(Distancia.ToString("F4", CultureInfo.InvariantCulture));
           



        }
    }
}

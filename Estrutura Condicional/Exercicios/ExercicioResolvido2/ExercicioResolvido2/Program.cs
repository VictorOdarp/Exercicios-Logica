using System;
using System.Globalization;




namespace Exercicio8Judge
{
    class Program
    {

        static void Main(string[] args)
        {

            double A, B, C, Delta, R1, R2;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Delta = Math.Pow(B, 2.0) - 4 * A * C;
            R1 = (-B + Math.Sqrt(Delta)) / (2.0 * A);
            R2 = (-B - Math.Sqrt(Delta)) / (2.0 * A);

            if (A <= 0)
            {
                Console.WriteLine("Impossível calcular");
            }
            else
            {
                if (Delta < 0)
                {
                    Console.WriteLine("Impossível calcular");
                }
                else
                {
                    Console.WriteLine("R1 = " + R1.ToString("F5"), CultureInfo.InvariantCulture);
                    Console.WriteLine("R2 = " + R2.ToString("F5"), CultureInfo.InvariantCulture);

                }
            }








        }


    }
}
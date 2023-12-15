using System;
using System.Globalization;

namespace URI1043
{
    class Program
    {
        static void Main(string[] args)
        {

            double N1, N2, N3, Perimetro, Area;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            N1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            N2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
            N3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            if (N1 + N2 > N3 && N2 + N3 > N1 && N3 + N1 > N2)
            {
                Perimetro = N1 + N2 + N3;
                Console.WriteLine("Perimetro = " +  Perimetro.ToString("F1"), CultureInfo.InvariantCulture);
            }
            else
            {
                Area = (N1 + N2) * N3 / 2.0;
                Console.WriteLine("Area = " + Area.ToString("F1"), CultureInfo.InvariantCulture);
            }





        }
    }



}
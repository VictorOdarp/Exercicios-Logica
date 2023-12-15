using System;

namespace URI1060
{
    class Program
    {
        static void Main(string[] args)
        {

            double N1, N2, N3, N4, N5, N6, Positivo;

            N1 = (int)double.Parse(Console.ReadLine());
            N2 = (int)double.Parse(Console.ReadLine());
            N3 = (int)double.Parse(Console.ReadLine());
            N4 = (int)double.Parse(Console.ReadLine());
            N5 = (int)double.Parse(Console.ReadLine());
            N6 = (int)double.Parse(Console.ReadLine());
            Positivo = 0;

            if (N1 > 0)
            {
                Positivo++;
                Positivo = Positivo++;
            }
            if (N2 > 0)
            {
                Positivo++;
                Positivo = Positivo++;
            }
            if (N3 > 0)
            {
                Positivo++;
                Positivo = Positivo++;
            }
            if (N4 > 0)
            {
                Positivo++;
                Positivo = Positivo++;
            }
            if (N5 > 0)
            {
                Positivo++;
                Positivo = Positivo++;
            }
            if (N6 > 0)
            {
                Positivo++;
                Positivo = Positivo++;
            }


            Console.WriteLine(Positivo + " valores positivos");



        }
    }
}



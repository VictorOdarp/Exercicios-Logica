using System;
using System.Globalization;

namespace SintaxeOpcionalForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, posição;
            double[] Numeros;
            string[] vet;
            double Maiornúmero;

            N = int.Parse(Console.ReadLine());
            Numeros = new double[N];

            vet = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                Numeros[i] = double.Parse(vet[i], CultureInfo.InvariantCulture);
            }

            Maiornúmero = 0;
            posição = 0;
            

            for (int i = 0; i < N; i++)
            { 
                if (Numeros[i] > Maiornúmero)
                {
                    Maiornúmero = Numeros[i];
                    posição = i; 

                }
            }

            Console.WriteLine(Maiornúmero.ToString("F1"), CultureInfo.InvariantCulture);
            Console.WriteLine(posição);




        }
    }
}
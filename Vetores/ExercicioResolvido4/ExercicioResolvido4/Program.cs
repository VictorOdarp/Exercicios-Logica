using System;
using System.Globalization;

namespace ExercicioResolvido4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            string[] nome, vet;
            int[] idade;
            double[] altura; 

            N = int.Parse(Console.ReadLine());
            nome = new string[N];
            idade = new int[N];
            altura = new double[N];


            for (int i = 0; i < N; i++)
            {
                vet = Console.ReadLine().Split(' ');
                nome[i] = (vet[0]);
                idade[i] = int.Parse(vet[1]);
                altura[i] = double.Parse(vet[2], CultureInfo.InvariantCulture);
            }

            double somaaltura = 0.0;
            double médiaaltura = 0.0;

            for (int i = 0; i < N; i++)
            {
                somaaltura = altura[i] + somaaltura;
                
            }
           
            médiaaltura = somaaltura / N;
            Console.WriteLine("Altura média: " + médiaaltura.ToString("F2"), CultureInfo.InvariantCulture);

            int menor16 = 0;
            double médiaidade = 0.0;

            for (int i = 0; i < N; i++)
            {
                if (idade[i] < 16)
                {
                    menor16++;
                }
                
            }

            médiaidade = (double) menor16 / N * 100;
            Console.WriteLine("Pessoas com menos de 16 anos: " + médiaidade.ToString("F1") + "%", CultureInfo.InvariantCulture);







        }
    }
}

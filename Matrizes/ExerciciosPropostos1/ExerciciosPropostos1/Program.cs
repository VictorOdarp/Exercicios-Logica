using System;

namespace ExercicioProposto
{
    class Program
    {
        static void Main(string[] args)
        {
            int L, C;
            int[,] matriz;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            L = int.Parse(vet[0]);
            C = int.Parse(vet[1]);
            matriz = new int[L, C];

            for (int i = 0;  i < L; i++)
            {
                vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < C; j++)
                {
                    matriz[i, j] = int.Parse(vet[j]);
                }
            }

            Console.WriteLine("VALORES NEGATIVOS: ");

            for (int i = 0; i < L; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    if (matriz[i,j] < 0)
                    {
                        Console.WriteLine(matriz[i, j]);
                    }
                }
            }
        }
    }
}

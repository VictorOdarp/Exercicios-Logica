using System;
using System.Runtime.Serialization;

namespace ExercicioProposto5
{
    class Program
    {
        static void Main(string[] args)
        {
            int L, C;
            int[,] MatrizA, MatrizB, MatrizC;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            L = int.Parse(vet[0]);
            C = int.Parse(vet[1]); 
            MatrizA = new int[L, C];
            MatrizB = new int[L, C];
            MatrizC = new int[L, C];

            for ( int i = 0;  i < L; i++ )
            {
                vet = Console.ReadLine().Split(' ');
                for ( int j = 0;  j < C; j++ )
                {
                    MatrizA[i, j] = int.Parse(vet[j]);
                }
            }
            for (int i = 0; i < L; i++)
            {
                vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < C; j++)
                {
                    MatrizB[i, j] = int.Parse(vet[j]);
                }
            }

            for (int i = 0; i < L; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    MatrizC[i,j] = MatrizA[i,j] + MatrizB[i,j];
                }
            }
            for (int i = 0; i < L; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    Console.Write(MatrizC[i, j] + " ");
                }
               
                Console.WriteLine();
            }


        }
    }
}


using System;
using System.Text.Json.Serialization;

namespace ExercicioProposto7
{
    class Program
    {
        static void Main(string[] args)
        {
            int L, C, girarFila;
            int[,] matriz;
            string[] vet;

            L = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            matriz = new int[L, C];

            for (int i = 0;  i < L; i++)
            {
                vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < C; j++)
                {
                    matriz[i,j] = int.Parse(vet[j]);
                }
            }

            girarFila = int.Parse(Console.ReadLine());
            girarFila = girarFila - 1;

            int ultimoDaFila = matriz[girarFila, C - 1];

            for (int j = C - 1 ; j > 0; j--)
            {
                matriz[girarFila,j] = matriz[girarFila, j - 1];

            }

            matriz[girarFila, 0] = ultimoDaFila;

            for (int i = 0; i < L;  ++i)
            {
                for (int j = 0; j < C; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }

                Console.WriteLine();
            }

        }
    }
}

using System;

namespace ExercicioVetor
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
            matriz = new int[L,C];

            for (int i = 0; i < L; i++)
            {
                vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < C; j++)
                {
                    matriz[i, j] = int.Parse(vet[j]);
            }   }

            for (int i = 0; i < L; i++)
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
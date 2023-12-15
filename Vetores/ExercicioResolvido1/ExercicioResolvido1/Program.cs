using System;

namespace ExercicioResolvido
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

            for (int i = 0; i < L; i++)
            {
                vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < C; j++)
                {
                    matriz[i,j] = int.Parse(vet[j]);
                }
            }



            int[] vetor = new int[L];

            for (int i = 0; i < L; i++)
            {
                int soma = 0;
                for (int j = 0; j < C; j++)
                {
                    soma = soma + matriz[i, j];
                }
                
                vetor[i] = soma;
                Console.WriteLine(vetor[i]);
            }


        }
    }
}

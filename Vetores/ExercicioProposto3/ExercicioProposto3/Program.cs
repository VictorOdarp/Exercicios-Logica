using System;
using System.Runtime.ExceptionServices;

namespace ExerciciosPropostos3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int[] A, B, C;
            string[] vet1, vet2;

            N = int.Parse(Console.ReadLine());
            A = new int[N];
            B = new int[N];
            C = new int[N];
            
            vet1 = Console.ReadLine().Split(' ');
            vet2 = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(vet1[i]);
                B[i] = int.Parse(vet2[i]);
                C[i] = A[i] + B[i];
            }

            for (int i = 0; i < N; i++)
            {
                Console.Write(C[i] + " ");
            }
        }
    }
}
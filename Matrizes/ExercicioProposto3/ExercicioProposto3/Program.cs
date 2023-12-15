using System;

namespace ExercicioProposto3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int[,] matriz;
            string[] vet;

            N = int.Parse(Console.ReadLine());
            matriz = new int[N,N];

            for ( int i = 0; i < N; i++ )
            {
                vet = Console.ReadLine().Split(' ');
                for ( int j = 0;  j < N; j++ )
                {
                    matriz[i,j] = int.Parse(vet[j]);
                }
            }

            for ( int i = 0; i < N; i++ )
            {
                int maiorNumero = 0;

                for ( int j = 0; j < N; j++ )
                {
                    if (maiorNumero < matriz[i,j])
                    {
                        maiorNumero = matriz[i,j];
                    }
                }

                Console.WriteLine(maiorNumero);
                
            }

        }
    }
}
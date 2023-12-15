using System; 

namespace ExercicioResolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            int M;
            int N;
            int[,] matriz;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            M = int.Parse(vet[0]);
            N = int.Parse(vet[1]);
            matriz = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    matriz[i, j] = int.Parse(vet[j]);
                }

            }
            
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(matriz[i, j] + " ");  
                    
                }
                
                Console.WriteLine();
            }






        }
    }
}

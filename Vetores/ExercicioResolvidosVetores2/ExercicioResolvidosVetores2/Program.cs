using System; 

namespace ExercicioResolvido2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int[] X;
            string[] vet;

            
            N = int.Parse(Console.ReadLine());
            X = new int[N];

            vet = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                X[i] = int.Parse(vet[i]);
            }

            for (int i = 0; i < N; i++)
            {
               if (X[i] < 0)
                {
                    Console.WriteLine(X[i]);
                }
            }
           
        }
    }
}

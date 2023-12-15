using System; 

namespace ExercicioResolvido2
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

            for (int i = 0;  i < N; i++)
            {
                vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++ )
                {
                    matriz[i,j] = int.Parse(vet[j]);
                }
            }

            int Cont = 0;

            Console.WriteLine("DIAGONAL PRINCIPAL: ");

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i == j)
                    {
                        Console.Write(matriz[i, j] + " ");
                    }
                    if (matriz[i, j] < 0)
                    {
                        Cont++;
                    }
                    
                } 
                
            }

            Console.WriteLine();
            Console.WriteLine("QUANTIDADE DE NEGATIVOS = " +  Cont);
        }
    }
}

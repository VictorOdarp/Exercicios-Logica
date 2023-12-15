using System;
using System.Globalization;

namespace ExercicioProposto6
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double[,] matriz;
            string[] vet;

            N = int.Parse(Console.ReadLine());
            matriz = new double[N,N];

            for ( int i = 0;  i < N; i++ )
            {
                vet = Console.ReadLine().Split(' ');
                for ( int j = 0; j < N; j++ )
                {
                    matriz[i,j] = double.Parse(vet[j], CultureInfo.InvariantCulture);
                }
            }

            double soma = 0.0;

            for ( int i = 0; i < N; i++ )
            {
                for ( int j = 0; j < N; j++ )
                {
                    if (matriz[i, j] > 0)
                    {
                        soma = soma + matriz[i,j];
                    }
                }
            }
            
            Console.WriteLine("SOMA DOS POSITIVOS: " + soma.ToString("F1") + " ", CultureInfo.InvariantCulture);

            int linhaEscolhida = int.Parse(Console.ReadLine());
            Console.Write("LINHA ESCOLHIDA: ");

            for ( int i = linhaEscolhida; i <= linhaEscolhida; i++ )
            {
                for ( int j = 0; j < N; j++ )
                {
                    Console.Write(matriz[linhaEscolhida, j].ToString("F1") + " ", CultureInfo.InvariantCulture);
                }
            }

            Console.WriteLine();
            int colunaEscolhida = int.Parse(Console.ReadLine());
            Console.Write("COLUNA ESCOLHIDA: ");

            for ( int i = 0; i < N; i++ )
            {
                for ( int j = colunaEscolhida; j <= colunaEscolhida; j++ )
                {
                    Console.Write(matriz[i, colunaEscolhida].ToString("F1") + " ", CultureInfo.InvariantCulture);
                }
            }

            Console.WriteLine();
            Console.Write("DIAGONAL PRINCIPAL: ");

            for ( int i = 0; i < N; i++ )
            {
                for ( int j = 0; j < N; j++ )
                {
                    if (i == j)
                    {
                        Console.Write(matriz[i, j].ToString("F1") + " ", CultureInfo.InvariantCulture);
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("MATRIZ ALTERADA: ");

            for ( int i = 0; i < N; ++i )
            {
                for ( int j = 0; j < N; j++ )
                {
                    if (matriz[i, j] < 0)
                    {
                        Console.Write(Math.Pow(matriz[i, j],2.0).ToString("F1") + " ", CultureInfo.InvariantCulture);
                    }
                    else
                    {
                        Console.Write(matriz[i, j].ToString("F1") + " ", CultureInfo.InvariantCulture);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

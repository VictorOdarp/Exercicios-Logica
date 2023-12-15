
using System;
using System.Globalization;



namespace ExercicioProposto7
{
    class Program
    {
       static void Main(string[] args)
        {
            int N;
            string[] nomes, vet;
            double[] nota1, nota2;

            N = int.Parse(Console.ReadLine());
            nomes = new string[N];
            nota1 = new double[N];
            nota2 = new double[N];

            for (int i = 0; i < N; i++)
            {
                vet = Console.ReadLine().Split(' ');
                nomes[i] = vet[0];
                nota1[i] = double.Parse(vet[1], CultureInfo.InvariantCulture);
                nota2[i] = double.Parse(vet[2], CultureInfo.InvariantCulture);
            }

            double média = 0.0;
            Console.WriteLine("Alunos aprovados:");

            for (int i = 0; i < N; i++)
            {
                média = (nota1[i] + nota2[i]) / 2;

                if (média >= 6.0)
                {
                    Console.WriteLine(nomes[i]);
                }
            }

        }
    }
}

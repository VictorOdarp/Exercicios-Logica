using System;

namespace URI1149
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, N, soma, i;
            string[] vet;
            soma = 0;
            i = 1;
            
            vet = Console.ReadLine().Split(' ');
            A = int.Parse(vet[0]);
            N = int.Parse(vet[i]); ;

            while (N <= 0)
            {
                i = i + 1;
                N = int.Parse(vet[i]);
            }

            for (i = 0; i < N; i++)
            {
                soma = soma + A + i;
                          
            }

            Console.WriteLine(soma);
           

        }
    }
}

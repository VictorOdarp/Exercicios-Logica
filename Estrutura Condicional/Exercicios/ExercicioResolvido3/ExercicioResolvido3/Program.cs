using System;
using System.Globalization;




namespace Exercicio8Judge
{
    class Program
    {

        static void Main(string[] args)
        {

            int A, B, C;
            string[] vet = Console.ReadLine().Split(' ');


            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);

            if (A < B && A < C)
            {
                Console.WriteLine("MENOR = " + A);
            }
            else
            {
                if (B < A && B < C)
                {
                    Console.WriteLine("MENOR = " + B);
                }
                else
                {
                    Console.WriteLine("MENOR = " + C);

                }
            }







        }


    }
}
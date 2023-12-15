using System;
using System.Globalization;




namespace Exercicio8Judge
{
    class Program
    {

        static void Main(string[] args)
        {

            int A, B;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);

            if (A > B && A % B == 0 || B > A && B % A == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }








        }


    }
}

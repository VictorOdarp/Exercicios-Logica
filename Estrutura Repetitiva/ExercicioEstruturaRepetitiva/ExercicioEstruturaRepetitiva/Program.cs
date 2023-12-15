using System;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, SOMA;
            
            X = int.Parse(Console.ReadLine());
            SOMA = 0;

            while (X > 0) 
            {
                SOMA = SOMA + X;
                X = int.Parse(Console.ReadLine());
                

            }

            Console.WriteLine(SOMA);
            

            

        }
    }
}
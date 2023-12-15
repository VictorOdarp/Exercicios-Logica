using System;

namespace URI1071
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, X, fora, dentro;

            N = int.Parse(Console.ReadLine());
            X = 0; 
            dentro = 0;
            fora = 0;

            for (int i = 0; i < N; i++)
            {
                X = int.Parse(Console.ReadLine());
                
                if (X >= 10 && X <= 20)
                {
                    dentro++; 
                }
                else
                {
                    fora++;
                }
            }

            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out");


        }
    }
}

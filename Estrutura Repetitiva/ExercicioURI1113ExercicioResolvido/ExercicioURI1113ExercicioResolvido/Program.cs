using System;

namespace URI1113
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            X = int.Parse(vet[0]);
            Y = int.Parse(vet[1]);

            while (X != Y)
            {
                if (X > Y)
                {
                    Console.WriteLine("Decrescente");
                    
                }
                else if (Y > X)
                {
                    Console.WriteLine("Crescente");
                    
                }
                vet = Console.ReadLine().Split(' ');
                X = int.Parse(vet[0]);
                Y = int.Parse(vet[1]);
            }
            
        }
    }
}
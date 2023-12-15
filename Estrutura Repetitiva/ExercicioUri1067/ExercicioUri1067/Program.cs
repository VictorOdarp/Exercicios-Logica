using System;

namespace URI1067
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, soma; 

            X = int.Parse(Console.ReadLine());
            soma = 0;

            for (int i = 0; i < X;  i++)
            {
                if (i % 2 == 0)
                {
                    soma = i + 1;
                    Console.WriteLine(soma);
                }
                
            }
            
        }
    }
}
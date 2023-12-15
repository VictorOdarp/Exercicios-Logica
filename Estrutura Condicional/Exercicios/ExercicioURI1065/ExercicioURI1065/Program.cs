using System;
using System.Transactions;

namespace URI1065
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1, N2, N3, N4, N5, Par;
            Par = 0;

            N1 = int.Parse(Console.ReadLine());
            N2 = int.Parse(Console.ReadLine());
            N3 = int.Parse(Console.ReadLine());
            N4 = int.Parse(Console.ReadLine());
            N5 = int.Parse(Console.ReadLine());

            if (N1 % 2 == 0)
            {
                Par += 1;
            }
            if (N2 % 2 == 0)
            {
                Par += 1;
            }
            if (N3 % 2 == 0)
            {
                Par += 1;
            }
            if (N4 % 2 == 0)
            {
                Par += 1;
            }
            if (N5 % 2 == 0)
            {
                Par += 1;
            }

            Console.WriteLine(Par + " valores pares");
        }   
    }
}
﻿using System;

namespace URI1071
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, soma;
            soma = 0;

            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + "^2 = " + Math.Pow(i, 2));
                }
            }
        }
    }
}
﻿using System;


namespace URI1078
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, SOMA;

            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10;  i++)
            {
                SOMA = i * N;
                Console.WriteLine(i + " x " + N + " = " + SOMA);
            }
        }
    }



}


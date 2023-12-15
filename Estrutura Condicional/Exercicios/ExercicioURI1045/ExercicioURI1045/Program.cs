using System;
using System.ComponentModel.Design;
using System.Numerics;

namespace URI1045
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1, N2, N3, A, B, C;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            N1  = double.Parse(vet[0]);
            N2 = double.Parse(vet[1]);
            N3 = double.Parse(vet[2]);

            if (Math.Max(N1, N2) > N3)
            {
                A = Math.Max(N1, N2);
                if (A > Math.Max(N2, N3))
                {
                    B = Math.Max(N2, N3);
                    C = Math.Min(N2, N3);
                }
                else
                {
                    C = Math.Max(N1, N3);
                    B = Math.Min(N1, N3);
                    
                }
                   
            }
            else
            {
                A = N3;
                B = Math.Max(N1, N2);
                C = Math.Min(N1, N2);
            }


            if (A >= B + C)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
                if (A == B && B == C && C == A && C == B)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (A == B || A == C || B == A || B == C || C == A || C == B)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
            else if (Math.Pow(A, 2.0) == Math.Pow(B, 2.0) + Math.Pow(C, 2.0))
            {
                Console.WriteLine("TRIANGULO RETANGULO");
                if (A == B && B == C && C == A && C == B)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (A == B || A == C || B == A || B == C || C == A || C == B)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
            else if (Math.Pow(A, 2.0) > Math.Pow(B, 2.0) + Math.Pow(C, 2.0))
            {
                
                Console.WriteLine("TRIANGULO OBTUSANGULO");
                if (A == B && B == C && C == A && C == B)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (A == B || A == C || B == A || B == C || C == A || C == B)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
            else if (Math.Pow(A, 2.0) < Math.Pow(B, 2.0) + Math.Pow(C, 2.0))
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
                if (A == B && B == C && C == A && C == B)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (A == B || A == C || B == A || B == C || C == A || C == B)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }

            }
            
            





        }






    }




}
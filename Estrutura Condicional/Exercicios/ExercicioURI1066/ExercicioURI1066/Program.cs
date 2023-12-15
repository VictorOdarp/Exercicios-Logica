using System;

namespace URI1066
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1, N2, N3, N4, N5, Positivo, Negativo, Par, Impar;
            Positivo = 0;
            Par = 0;
            Impar = 0;
            Negativo = 0;

            N1 = int.Parse(Console.ReadLine());
            N2 = int.Parse(Console.ReadLine());
            N3 = int.Parse(Console.ReadLine());
            N4 = int.Parse(Console.ReadLine());
            N5 = int.Parse(Console.ReadLine());
            

            if (N1 >= 0)
            {
                if (N1 > 0)
                {
                    Positivo += 1;
                }
                if (N1 % 2 == 0)
                {
                    Par += 1;
                }
                else
                {
                    Impar += 1;
                }
            }
            else if (N1 < 0)
            {
                Negativo += 1;
                if (N1 % 2 == 0)
                {
                    Par += 1;
                }
                else
                {
                    Impar += 1;
                }
            }
            if (N2 >= 0)
            {
                if (N2 > 0)
                {
                    Positivo += 1;
                }
                if (N2 % 2 == 0)
                {
                    Par += 1;
                }
                else
                {
                    Impar += 1;
                }
            }
            else if (N2 < 0)
            {
                Negativo += 1;
                if (N2 % 2 == 0)
                {
                    Par += 1;
                }
                else
                {
                    Impar += 1;
                }
            }
            if (N3 >= 0)
            {
                if (N3 > 0)
                {
                    Positivo += 1;
                }
                if (N3 % 2 == 0)
                {
                    Par += 1;
                }
                else
                {
                    Impar += 1;
                }
            }
            else if (N3 < 0)
            {
                Negativo += 1;
                if (N3 % 2 == 0)
                {
                    Par += 1;
                }
                else
                {
                    Impar += 1;
                }
            }
            if (N4 >= 0)
            {
                if (N4 > 0)
                {
                    Positivo += 1;
                }
                if (N4 % 2 == 0)
                {
                    Par += 1;
                }
                else
                {
                    Impar += 1;
                }
            }
            else if (N4 < 0)
            {
                Negativo += 1;
                if (N4 % 2 == 0)
                {
                    Par += 1;
                }
                else
                {
                    Impar += 1;
                }
            }
            if (N5 >= 0)
            {
                if (N5 > 0)
                {
                    Positivo += 1;
                }
                if (N5 % 2 == 0)
                {
                    Par += 1;
                }
                else
                {
                    Impar += 1;
                }
            }
            else if (N5 < 0)
            {
                Negativo += 1;
                if (N5 % 2 == 0)
                {
                    Par += 1;
                }
                else
                {
                    Impar += 1;
                }
            }


            Console.WriteLine(Par + " valor (es) par (es)");
            Console.WriteLine(Impar + " valor (es) impar (es)");
            Console.WriteLine(Positivo + " valor (es) positivo (s)");
            Console.WriteLine(Negativo + " valor (es) negativo (s)");







        }   
    }
}

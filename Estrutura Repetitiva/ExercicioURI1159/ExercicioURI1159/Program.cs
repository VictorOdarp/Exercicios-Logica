using System;

namespace URI1159
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, soma, N1, N2, N3, N4, N5, Resultado;
            X = int.Parse(Console.ReadLine());
            soma = 0;
            Resultado = 0;

            while (X != 0)
            {
                if (X % 2 == 0)
                {


                    N1 = X;
                    soma = N1 + 2;
                    N2 = soma;
                    soma = N2 + 2;
                    N3 = soma;
                    soma = N3 + 2;
                    N4 = soma;
                    soma = N4 + 2;
                    N5 = soma;
                    soma = N5 + 2;


                    Resultado = N1 + N2 + N3 + N4 + N5;
                    Console.WriteLine(Resultado);



                }
                else if (X % 2 == 1)
                {
                    X = X + 1;

                    N1 = X;
                    soma = N1 + 2;
                    N2 = soma;
                    soma = N2 + 2;
                    N3 = soma;
                    soma = N3 + 2;
                    N4 = soma;
                    soma = N4 + 2;
                    N5 = soma;
                    soma = N5 + 2;


                    Resultado = N1 + N2 + N3 + N4 + N5;
                    Console.WriteLine(Resultado);
                }

                X = int.Parse(Console.ReadLine());

            }

        }
    }
}
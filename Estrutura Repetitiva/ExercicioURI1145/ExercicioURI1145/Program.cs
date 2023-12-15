using System;

namespace URI1145
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y, cont, soma;
            string[] vet;
            soma = 0;
            cont = 1;

            vet = Console.ReadLine().Split(' ');
            X = int.Parse(vet[0]);
            Y = int.Parse(vet[1]);

            for (int i = 1; cont <= Y; i++)
            {

                if (soma < X)
                {

                    Console.Write(cont + " ");
                    cont += 1;
                    soma += 1;

                }
                else
                {
                    Console.Write("\n");
                    soma = 0;
                }


            }


        }
    }
}
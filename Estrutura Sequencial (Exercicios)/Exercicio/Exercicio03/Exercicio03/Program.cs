using System;
using System.Globalization;



namespace Exercicio3
{
    class Program
    {

        static void Main(string[] args)
        {

            string[] Linha1 = Console.ReadLine().Split(' ');

            string NOME1 = Linha1[0];
            int Idade1 = int.Parse(Linha1[1], CultureInfo.InvariantCulture);

            string[] Linha2 = Console.ReadLine().Split(' ');

            string NOME2 = Linha2[0];
            int Idade2 = int.Parse(Linha2[1], CultureInfo.InvariantCulture);

            double IdadeMédia = (Idade1 + Idade2) / 2.0;

            Console.WriteLine("A idade média de " + NOME1 + " e " + NOME2 + " é de " + IdadeMédia.ToString("F1", CultureInfo.InvariantCulture) + " anos");


            

        }

    }
}
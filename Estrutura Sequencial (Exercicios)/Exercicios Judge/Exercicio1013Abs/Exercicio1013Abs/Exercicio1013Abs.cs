using System;
using System.Globalization;



namespace Exercicio10Judge
{
    class Program
    {

        static void Main(string[] args)
        {
            int A, B, C;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            A = int.Parse(vet[0], CultureInfo.InvariantCulture);
            B = int.Parse(vet[1], CultureInfo.InvariantCulture);
            C = int.Parse(vet[2], CultureInfo.InvariantCulture);

            int MaiorAB = (A + B + Math.Abs(A - B)) / 2;
            int MaiorABC = (MaiorAB + C + Math.Abs(MaiorAB - C)) / 2;

            
            Console.WriteLine(MaiorABC + " eh o maior");



        }
    }
}

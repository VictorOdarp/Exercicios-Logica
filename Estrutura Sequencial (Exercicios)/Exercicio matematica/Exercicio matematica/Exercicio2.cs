using System;
using System.Globalization;

namespace Exercicio
{
    class Program
    {

        static void Main(string[] args)
        {


            Console.WriteLine("Entre com seu nome completo: ");

            string Nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa? ");

            int Quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto: ");

            double Produto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha)");

            string[] vet = Console.ReadLine().Split(' ');
            string UltimoNome = vet[0];
            int Idade = int.Parse(vet[1]);
            double Altura = double.Parse(vet[2], CultureInfo.InvariantCulture);



            Console.WriteLine("Você digitou: ");
            Console.WriteLine(Nome);
            Console.WriteLine(Quartos);
            Console.WriteLine(Produto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(UltimoNome);
            Console.WriteLine(Idade);
            Console.WriteLine(Altura.ToString("F2", CultureInfo.InvariantCulture));























        }








    }
}

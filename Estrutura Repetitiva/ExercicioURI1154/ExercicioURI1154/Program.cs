using System;
using System.Globalization;

namespace URI1154
{
    class Program
    {
        static void Main(string[] args)
        {
            double idade, contador, soma, média;
            idade = double.Parse(Console.ReadLine());
            soma = 0;
            contador = 0;

            while (idade > 0)
            {
                soma  = soma + idade;
                contador++;
                idade = double.Parse(Console.ReadLine());
            }

            média = soma / contador;

            Console.WriteLine(média.ToString("F2"), CultureInfo.InvariantCulture);
            
            







        }
    }
}

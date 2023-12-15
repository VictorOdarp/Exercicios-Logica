using System;
using System.Globalization;




namespace Exercicio8Judge
{
    class Program
    {

        static void Main(string[] args)
        {

            double minutos;
            double conta;
            double valorfinal;

            conta = 50.0;
            minutos = int.Parse(Console.ReadLine());
            

            if (minutos > 100)
            {
                conta += (minutos - 100) * 2.0;
                Console.WriteLine("Valor a pagar: R$ " + conta.ToString("F2"), CultureInfo.InvariantCulture);
            }
            else
            {
                Console.WriteLine("Valor a pagar: R$ " + conta.ToString("F2"), CultureInfo.InvariantCulture);
            }
            








        }


    }
}
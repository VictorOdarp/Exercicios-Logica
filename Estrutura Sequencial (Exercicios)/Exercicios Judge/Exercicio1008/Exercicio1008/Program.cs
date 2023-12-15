using System;
using System.Globalization;




namespace Exercicio8Judge
{
    class Program
    {

        static void Main(string[] args)
        {
           int Funcionario = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           int HorasTrabalhadas = int.Parse(Console.ReadLine());   
           double ValorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           double Salário = HorasTrabalhadas * ValorHora;

            Console.WriteLine("NUMBER = " + Funcionario);
            Console.WriteLine("SALARY = U$ " + Salário.ToString("F2"), CultureInfo.InvariantCulture) ;

           




        }

    }
}

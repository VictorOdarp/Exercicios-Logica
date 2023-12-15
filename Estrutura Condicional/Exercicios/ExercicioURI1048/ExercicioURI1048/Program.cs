using System;
using System.Globalization;

namespace URI1048
{
    class Program
    {

        static void Main(string[] args)
        {

            double Salário, NovoSalário, Porcentagem, ValorReajuste;

            Salário = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (Salário >= 0 && Salário <= 400.00)
            {
                Porcentagem = 15.0;
                NovoSalário = Salário + (Salário * (Porcentagem / 100));
                ValorReajuste = Salário * Porcentagem / 100;

                Console.WriteLine("Novo salario: " + NovoSalário.ToString("F2"), CultureInfo.InvariantCulture);
                Console.WriteLine("Reajuste ganho: " + ValorReajuste.ToString("F2"), CultureInfo.InvariantCulture);
                Console.WriteLine("Em percentual: " + Porcentagem + " %");

            }
            else if (Salário >= 400.01 && Salário <= 800.00)
            {
                Porcentagem = 12.0;
                NovoSalário = Salário + (Salário * (Porcentagem / 100));
                ValorReajuste = Salário * Porcentagem / 100;

                Console.WriteLine("Novo salario: " + NovoSalário.ToString("F2"), CultureInfo.InvariantCulture);
                Console.WriteLine("Reajuste ganho: " + ValorReajuste.ToString("F2"), CultureInfo.InvariantCulture);
                Console.WriteLine("Em percentual: " + Porcentagem + " %");

            }
            else if (Salário >= 800.01 && Salário <= 1200.00)
            {
                Porcentagem = 10.0;
                NovoSalário = Salário + (Salário * (Porcentagem / 100));
                ValorReajuste = Salário * Porcentagem / 100;

                Console.WriteLine("Novo salario: " + NovoSalário.ToString("F2"), CultureInfo.InvariantCulture);
                Console.WriteLine("Reajuste ganho: " + ValorReajuste.ToString("F2"), CultureInfo.InvariantCulture);
                Console.WriteLine("Em percentual: " + Porcentagem + " %");

            }
            else if (Salário >= 1200.01 && Salário <= 2000.00)
            {
                Porcentagem = 7.0;
                NovoSalário = Salário + (Salário * (Porcentagem / 100));
                ValorReajuste = Salário * Porcentagem / 100;

                Console.WriteLine("Novo salario: " + NovoSalário.ToString("F2"), CultureInfo.InvariantCulture);
                Console.WriteLine("Reajuste ganho: " + ValorReajuste.ToString("F2"), CultureInfo.InvariantCulture);
                Console.WriteLine("Em percentual: " + Porcentagem + " %");

            }
            else if (Salário >= 2000.00)
            {
                Porcentagem = 4.0;
                NovoSalário = Salário + (Salário * (Porcentagem / 100));
                ValorReajuste = Salário * Porcentagem / 100;

                Console.WriteLine("Novo salario: " + NovoSalário.ToString("F2"), CultureInfo.InvariantCulture);
                Console.WriteLine("Reajuste ganho: " + ValorReajuste.ToString("F2"), CultureInfo.InvariantCulture);
                Console.WriteLine("Em percentual: " + Porcentagem + " %");

            }




        }


    }

}

using System;
using System.Globalization;

namespace URI1037
{
    class Program
    {

        static void Main(string[] args)
        {
            double Valor, Intervalo;

            Valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (Valor >= 0 && Valor <= 25.0)
            {
                Intervalo = (0.25);
                Console.WriteLine("Intervalo " + "[" + Intervalo + "]", CultureInfo.InvariantCulture);
            }
            else if (Valor >= 25.01 && Valor <= 50.00)
            {
                Intervalo = (25.50);
                Console.WriteLine("Intervalo " + "(" + Intervalo.ToString("F2") + "]", CultureInfo.InvariantCulture);

            }
            else if (Valor >= 50.01 && Valor <= 75.00)
            {
                Intervalo = (50.75);
                Console.WriteLine("Intervalo " + "(" + Intervalo.ToString("F2") + "]", CultureInfo.InvariantCulture);


            }
            else if (Valor >= 75.01 && Valor <= 100.00)
            {
                Intervalo = (75.100);
                Console.WriteLine("Intervalo " + "(" + Intervalo.ToString("F3"), CultureInfo.InvariantCulture + "]");
                
            }
            else if (Valor < 0 || Valor > 100.00) {

                Console.WriteLine("Fora de intervalo");
            }
            
        }
}   }
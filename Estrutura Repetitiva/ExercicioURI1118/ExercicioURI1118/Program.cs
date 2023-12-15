using System;
using System.Globalization;

namespace URI1118
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, média, Novocalculo;
            

            nota1 = double. Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (nota1 < 0.0 || nota1 > 10.0)
            {
                Console.WriteLine("nota invalida");
                nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (nota2 < 0.0 || nota2 > 10.0)
            {
                Console.WriteLine("nota invalida");
                nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            média = (nota1 + nota2) / 2.0;
            Console.WriteLine("media = " + média.ToString("F2"), CultureInfo.InvariantCulture);

            Console.WriteLine("novo calculo (1-sim 2-nao)");
            Novocalculo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (Novocalculo < 1.0 || Novocalculo > 2.0)
            {
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                Novocalculo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            while (Novocalculo == 1.0)
            {
                nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (nota1 < 0.0 || nota1 > 10.0)
                {
                    Console.WriteLine("nota invalida");
                    nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
                while (nota2 < 0.0 || nota2 > 10.0)
                {
                    Console.WriteLine("nota invalida");
                    nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                média = (nota1 + nota2) / 2.0;
                Console.WriteLine("media = " + média.ToString("F2"), CultureInfo.InvariantCulture);

                Console.WriteLine("novo calculo (1-sim 2-nao)");
                Novocalculo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            }

            

            
        }
    }
}
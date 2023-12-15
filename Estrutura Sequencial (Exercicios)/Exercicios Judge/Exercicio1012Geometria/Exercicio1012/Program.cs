using System;
using System.Globalization;



namespace Exercicio10Judge
{
    class Program
    {

        static void Main(string[] args)
        {

           double A, B, C, Triangulo, Circulo, Trapézio, Quadrado, Retangulo, PI;
           string[] vet;

           vet = Console.ReadLine().Split(' ');
           A = double.Parse(vet[0], CultureInfo.InvariantCulture);
           B = double.Parse(vet[1], CultureInfo.InvariantCulture);
           C = double.Parse(vet[2], CultureInfo.InvariantCulture);
           PI = 3.14159;

           Triangulo = (A * C) / 2.0;
           Circulo = (PI * Math.Pow(C, 2.0));
           Trapézio = (A + B) * C / (2.0);
           Quadrado = (B * B);
           Retangulo = (A * B);

           Console.WriteLine("TRIANGULO: " +  Triangulo.ToString("F3", CultureInfo.InvariantCulture));
           Console.WriteLine("CIRCULO: " + Circulo.ToString("F3", CultureInfo.InvariantCulture));
           Console.WriteLine("TRAPEZIO: " + Trapézio.ToString("F3", CultureInfo.InvariantCulture));
           Console.WriteLine("QUADRADO: " + Quadrado.ToString("F3", CultureInfo.InvariantCulture));
           Console.WriteLine("RETANGULO: " + Retangulo.ToString("F3", CultureInfo.InvariantCulture));










        }
    }
}

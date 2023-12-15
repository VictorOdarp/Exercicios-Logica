using System;
using System.Globalization;

namespace ExercicioMatematica
{
    class Program
    {

        static void Main(string[] args)
        {
            double Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double Comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double MetrosQuadrados = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double Area = Largura * Comprimento; 
            double Preço = MetrosQuadrados * Area;

            Console.WriteLine("Area = " + Area.ToString("F2", CultureInfo.InvariantCulture) + " metros \n");
            Console.WriteLine("Preço = " + Preço.ToString("F2", CultureInfo.InvariantCulture) + " reais \n");

            
            Console.WriteLine("A area do terreno é de " + Area.ToString("F2", CultureInfo.InvariantCulture) + " metros \n");
            Console.WriteLine("E o preço é de " + Preço.ToString("F2", CultureInfo.InvariantCulture) + " reais \n");
            
            
            
    
        }
    }
}

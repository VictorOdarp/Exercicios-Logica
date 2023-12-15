using System;
using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            double idade, contador, soma, média;
            idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            soma = 0;
            contador = 0;

           if (idade > 0)
            {
                
               while (idade > 0)
                {
                    soma = idade + soma;
                    idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    contador++;
                    
                }
                média = soma / contador;
                Console.WriteLine(média.ToString("F2"), CultureInfo.InvariantCulture);
                  
            }
           else
            {
                Console.WriteLine("impossível calcular");
            }
         


            
        }
    }
}
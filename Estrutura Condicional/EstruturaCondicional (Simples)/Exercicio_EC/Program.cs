using System;
using System.Globalization;




namespace Exercicio8Judge
{
    class Program
    {

        static void Main(string[] args)
        {
            int horas = 20;

            if (horas > 0 && horas < 12) 
            {
                Console.WriteLine("Bom dia!");
            }
            if (horas > 12 && horas < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            if (horas > 18  && horas < 24)
            {
                Console.WriteLine("Boa noite!");
            }
            
          





        }


    }
}

using System;
using System.Globalization;




namespace Exercicio8Judge
{
    class Program
    {

        static void Main(string[] args)
        {

            double Código, ValorTotal;
            string[] vet;
            int Quantidade;

            vet = Console.ReadLine().Split(' ');
            Código = int.Parse(vet[0]);
            Quantidade = int.Parse(vet[1]);

            if (Código == 1) 
            {
                ValorTotal = (4.00 * Quantidade);
                Console.WriteLine("Total: R$" + ValorTotal.ToString("F2"), CultureInfo.InvariantCulture);
            }
            else
            {
                if (Código == 2)
                {
                    ValorTotal = (4.50 * Quantidade);
                    Console.WriteLine("Total: R$ " + ValorTotal.ToString("F2"), CultureInfo.InvariantCulture);
                }
                else
                {
                    if (Código == 3)
                    {
                        ValorTotal = (5.00 * Quantidade);
                        Console.WriteLine("Total: R$ " + ValorTotal.ToString("F2"), CultureInfo.InvariantCulture);
                    }
                    else
                    {
                        if (Código == 4)
                        {
                            ValorTotal = (2.00 * Quantidade);
                            Console.WriteLine("Total: R$ " + ValorTotal.ToString("F2"), CultureInfo.InvariantCulture);
                        }
                        else
                        {
                            if (Código == 5)
                            {
                                ValorTotal = (1.50 * Quantidade);
                                Console.WriteLine("Total: R$ " + ValorTotal.ToString("F2"),CultureInfo.InvariantCulture);
                            }
                        }
                    }
                }
                
                
                    

            }
            
                

            










        }


    }
}

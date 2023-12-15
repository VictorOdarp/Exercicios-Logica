using System;
using System.Globalization; 

namespace URI1094
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, NumerosCobaia;
            double somaTotalCobaia, Coelho, Rato, Sapo, PercentualCoelho, PercentualRato, PercentualSapo;
            string C, R, S, Cobaia;
            string[] vet;
            somaTotalCobaia = 0;
            Coelho = 0;
            Sapo = 0;
            Rato = 0;
           
            

            
            

            N = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < N; i++)
            {
                vet = Console.ReadLine().Split(' ');
                NumerosCobaia = int.Parse(vet[0]);
                Cobaia = (vet[1]);

                if (Cobaia == "C")
                {
                    Coelho = Coelho + NumerosCobaia; 

                }
                else if (Cobaia == "R")
                {
                    Rato = Rato + NumerosCobaia;  
                }
                else if (Cobaia == "S")
                {
                    Sapo = Sapo + NumerosCobaia;
                }

                somaTotalCobaia = NumerosCobaia + somaTotalCobaia;
                
            }

            PercentualCoelho = Coelho / somaTotalCobaia * 100;
            PercentualRato = Rato / somaTotalCobaia * 100;
            PercentualSapo = Sapo / somaTotalCobaia * 100;


            Console.WriteLine("Total: " + somaTotalCobaia + " cobaias");
            Console.WriteLine("Total de coelhos: " + Coelho);
            Console.WriteLine("Total de ratos: " + Rato);
            Console.WriteLine("Total de sapos: " + Sapo);
            Console.WriteLine("Percentual de coelhos: " + PercentualCoelho.ToString("F2") + " %", CultureInfo.InvariantCulture);
            Console.WriteLine("Percentual de ratos: " + PercentualRato.ToString("F2") + " %", CultureInfo.InvariantCulture);
            Console.WriteLine("Percentual de sapos: " + PercentualSapo.ToString("F2") + " %", CultureInfo.InvariantCulture);
        }
    }
}
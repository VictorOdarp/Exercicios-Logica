using System;
using System.Globalization;

namespace ExercicioProposto9
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            string[] produto, vet;
            double[] preçoDeCompra, preçoDeVenda;

            N = int.Parse(Console.ReadLine());
            produto = new string[N];
            preçoDeCompra = new double[N];
            preçoDeVenda = new double[N];

            for (int i = 0; i < N; i++)
            {
                vet = Console.ReadLine().Split(' ');
                produto[i] = vet[0];
                preçoDeCompra[i] = double.Parse(vet[1], CultureInfo.InvariantCulture);
                preçoDeVenda[i] = double.Parse(vet[2], CultureInfo.InvariantCulture);

            }

            double Cálculo, ValorTotalCompra, ValorTotalVenda, LucroTotal;
            double PorcentagemLucro = 0.0;
            int LucroBaixo = 0;
            int LucroMédio = 0;
            int LucroAlto = 0;
            Cálculo = 0.0;
            ValorTotalCompra = 0.0;
            ValorTotalVenda = 0.0;
            LucroTotal = 0.0;

            for (int i = 0; i < N; i++)
            {
                Cálculo = (preçoDeVenda[i] - preçoDeCompra[i]) * 100;
                PorcentagemLucro = Cálculo / preçoDeCompra[i];

                if (PorcentagemLucro < 10.0)
                {
                    LucroBaixo++;
                }
                else if (PorcentagemLucro >= 10.0 && PorcentagemLucro <= 20.0)
                {
                    LucroMédio++;
                }
                else if (PorcentagemLucro > 20.0)
                {
                    LucroAlto++;
                }
                
            }

            double somacompra = 0.0; 
            double somavenda = 0.0;

            for (int i = 0; i < N; i++)
            {
                somacompra = preçoDeCompra[i] + somacompra;
                somavenda = preçoDeVenda[i] + somavenda;
            }

            LucroTotal = somavenda - somacompra;

            Console.WriteLine("Lucro abaixo de 10%: " + LucroBaixo);
            Console.WriteLine("Lucro entre 10% e 20%: " + LucroMédio);
            Console.WriteLine("Lucro acima de 20%: " + LucroAlto);
            Console.WriteLine("Valor total de compra: " + somacompra.ToString("F2"), CultureInfo.InvariantCulture); 
            Console.WriteLine("Valor total de venda: " + somavenda.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Lucro total: " + LucroTotal.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}

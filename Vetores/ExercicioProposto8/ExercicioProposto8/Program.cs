using System;
using System.Globalization;

namespace ExercicioProposto8
{
   class Program
    {
        static void Main(string[] args)
        {
            int N;
            double[] altura;
            char[] sexo;
            string[] vet;

            N = int.Parse(Console.ReadLine());
            altura = new double[N];
            sexo = new char[N];

            for (int i = 0;  i < N; i++)
            {
                vet = Console.ReadLine().Split(' ');
                altura[i] = double.Parse(vet[0], CultureInfo.InvariantCulture);
                sexo[i] = char.Parse(vet[1]);
            }

            double menorAltura = altura[0];
            double maiorAltura = 0.0;
            double médiaAltura = 0.0;
            double soma = 0.0;
            int ContF = 0;
            int ContM = 0;

            for (int i = 0; i < N; i++)
            {
                
                if (menorAltura > altura[i])
                {
                    menorAltura = altura[i];
                }
                
                if (maiorAltura < altura[i])
                {
                    maiorAltura = altura[i];
                }

                if (sexo[i] == 'F')
                {
                    soma = altura[i] + soma;
                    ContF++;
                }
                
                if (sexo[i] == 'M')
                {
                    ContM++;
                }
                
            }

            médiaAltura = (double) soma / ContF;
            
            Console.WriteLine("Menor altura = " + menorAltura.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Maior altura = " + maiorAltura.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Media das alturas das mulheres = " + médiaAltura.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Numero de homens = " + ContM);


        }
    }
}

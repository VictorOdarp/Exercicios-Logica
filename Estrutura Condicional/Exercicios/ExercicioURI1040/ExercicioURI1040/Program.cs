using System;
using System.Globalization;

namespace URI1040
{

    class Program
    {
        static void Main(string[] args)
        {
            float Nota1, Nota2, Nota3, Nota4, Nota5, Média, NotaExame, MédiaFinal;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            Nota1 = float.Parse(vet[0], CultureInfo.InvariantCulture);
            Nota2 = float.Parse(vet[1], CultureInfo.InvariantCulture);
            Nota3 = float.Parse(vet[2], CultureInfo.InvariantCulture);
            Nota4 = float.Parse(vet[3], CultureInfo.InvariantCulture);

            Média = ((Nota1 * 2f) + (Nota2 * 3f) + (Nota3 * 4f) + (Nota4 * 1f)) / 10;

            if (Média < 5.0)
            {
                Console.WriteLine("Media: " + Média.ToString("F1"), CultureInfo.InvariantCulture);
                Console.WriteLine("Aluno reprovado.");
            }
            else if (Média >= 7.0)
            {
                Console.WriteLine("Media: " + Média.ToString("F1"), CultureInfo.InvariantCulture);
                Console.WriteLine("Aluno aprovado.");
            }
            else if (Média >= 5.0 && Média <= 6.9)
            {
                Nota5 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                NotaExame = Nota5;
                MédiaFinal = (Média + NotaExame) / 2;
                if (MédiaFinal >= 5.0)
                {
                    Console.WriteLine("Media: " + Média.ToString("F1"), CultureInfo.InvariantCulture);
                    Console.WriteLine("Aluno em exame.");
                    Console.WriteLine("Nota do exame: " + NotaExame.ToString("F1"), CultureInfo.InvariantCulture);
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine("Media final: " + MédiaFinal.ToString("F1"), CultureInfo.InvariantCulture);

                }
                else if (MédiaFinal <= 4.9)
                {
                    Console.WriteLine("Media: " + Média.ToString("F1"), CultureInfo.InvariantCulture);
                    Console.WriteLine("Aluno em exame.");
                    Console.WriteLine("Nota do exame: " + NotaExame.ToString("F1"), CultureInfo.InvariantCulture);
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine("Media final: " + MédiaFinal.ToString("F1"), CultureInfo.InvariantCulture);
                }
                
                
            }

            
            










        }







    }




}

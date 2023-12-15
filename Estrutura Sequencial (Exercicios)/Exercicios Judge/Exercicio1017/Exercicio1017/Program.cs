using System;
using System.Globalization;




namespace ExercicioJudge
{
    class Program
    {

        static void Main(string[] args)
        {
            int TempoGasto = int.Parse(Console.ReadLine());
            int VelocidadeMedia = int.Parse(Console.ReadLine());
            double LitrosViagem = TempoGasto * VelocidadeMedia / 12.0;



            Console.WriteLine(LitrosViagem.ToString("F3"), CultureInfo.InvariantCulture);


        }

    }
}

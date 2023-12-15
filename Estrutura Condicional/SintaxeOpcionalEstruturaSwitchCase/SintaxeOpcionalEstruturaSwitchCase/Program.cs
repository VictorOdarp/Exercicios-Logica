using System;

namespace SwitchCase
{
    class Program
    {

        static void Main(string[] args)
        {
            // Em vez de fazer a estrutura com IF ELSE, O Switch-Case seria usando o (Case1,Case2,Case3...) Break, default.
            int dia = int.Parse(Console.ReadLine());

            if (dia == 1)
            {
                Console.WriteLine("Dia da semana: Domingo");
            }
            else if (dia == 2)
            {
                Console.WriteLine("Dia da semana: Segunda-feira");
            }
            else if (dia == 3)
            {
                Console.WriteLine("Dia da semana: Terça-feira");
            }
            else if (dia == 4)
            {
                Console.WriteLine("Dia da semana: Quarta-feira");
            }
            else if (dia == 5)
            {
                Console.WriteLine("Dia da semana: Quinta-feira");
            }
            else if (dia == 6)
            {
                Console.WriteLine("Dia da semana: Sexta-feira");
            }
            else if (dia == 7)
            {
                Console.WriteLine("Dia da semana: Sábado");
            }
            else
            {
                Console.WriteLine("Dia da semana: Valor inválido");
            }







        }





    }


}



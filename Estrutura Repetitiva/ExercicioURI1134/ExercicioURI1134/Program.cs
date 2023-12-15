using System;


namespace URI1134
{
    class Program
    {
        static void Main(string[] args)
        {
            int Combustivel, Alcool, Gasolina, Diesel;
            Combustivel = int.Parse(Console.ReadLine());
            Alcool = 0;
            Gasolina = 0;
            Diesel = 0;

            while (Combustivel != 4)
            {
                if (Combustivel == 1)
                {
                    Alcool++;
                }
                else if (Combustivel == 2)
                {
                    Gasolina++;
                }
                else if (Combustivel == 3)
                {
                    Diesel++;
                }

                Combustivel = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + Alcool);
            Console.WriteLine("Gasolina: " + Gasolina);
            Console.WriteLine("Diesel: " + Diesel);
        }
    }
}
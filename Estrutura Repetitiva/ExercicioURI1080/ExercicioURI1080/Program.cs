using System;

namespace URI1080
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Numero, MaiorNumero, PosiçãoMaiorNumero; 
            PosiçãoMaiorNumero = 1;

            MaiorNumero = int.Parse(Console.ReadLine());

            for (int i = 1; i < 100; i++)
            {
                Numero = int.Parse(Console.ReadLine());
               
                if (Numero > MaiorNumero)
                {
                    MaiorNumero = Numero;
                    PosiçãoMaiorNumero = i + 1;

                }

            }

            Console.WriteLine(MaiorNumero);
            Console.WriteLine(PosiçãoMaiorNumero);
            


            

            

           

            


        }
    }
}
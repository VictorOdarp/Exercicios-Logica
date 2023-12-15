using System;

namespace Uri1016
{
    class program
    {

        static void Main(string[] args)
        {

            int Inicio, Final, Tempo;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            Inicio = int.Parse(vet[0]);
            Final = int.Parse(vet[1]);

            if (Inicio >= Final)
            {
                Tempo = Math.Abs((24 - Inicio) + Final);
                Console.WriteLine("O JOGO DUROU " + Tempo + " HORA (S)");

            }
            else
            {
                Tempo = Math.Abs(Inicio - Final);
                Console.WriteLine("O JOGO DUROU " + Tempo + " HORA (S)");
            }




        }




    }


}



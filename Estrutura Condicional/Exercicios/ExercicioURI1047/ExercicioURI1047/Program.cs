using System;
using System.ComponentModel.Design;

namespace URI1047
{
    class Program
    {
        static void Main(string[] args)
        {
            int HoraInicio, HoraFinal, MinutoInicio, MinutoFinal, DuraçãoHoras, DuraçãoMinutos, InstanteInicial, InstanteFinal, Duração;
            string[] vet;
           

            vet = Console.ReadLine().Split(' ');
            HoraInicio = int.Parse(vet[0]);
            MinutoInicio = int.Parse(vet[1]);
            HoraFinal = int.Parse(vet[2]);
            MinutoFinal = int.Parse(vet[3]);
            InstanteInicial = (HoraInicio * 60) + MinutoInicio;
            InstanteFinal = (HoraFinal * 60) + MinutoFinal;

            if (InstanteInicial < InstanteFinal)
            {
                Duração = InstanteFinal - InstanteInicial;
            }
            else
            {
                Duração = (24 * 60 - InstanteInicial) + InstanteFinal;
            }

            DuraçãoHoras = Duração / 60;
            DuraçãoMinutos = Duração % 60;

            Console.WriteLine("O JOGO DUROU " + DuraçãoHoras + " HORA (S) E " + DuraçãoMinutos + " MINUTO (S)");


            

           
           
            
            




        }





    }



}
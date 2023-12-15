using System;
using System.Globalization;



namespace Exercicio10Judge
{
    class Program
    {

        static void Main(string[] args)
        {

            int dia1, hora1, minuto1, segundos1, dia2, hora2, minuto2, segundos2, inicio, fim, duração, W, X, Y, Z;
            string[] valores;

            

            
            valores = Console.ReadLine().Split(':');
            hora1 = int.Parse(valores[0]);
            

            

            valores = Console.ReadLine().Split(':');
            hora2 = int.Parse(valores[0]);
            

            inicio = hora1 * 60 * 60;
            fim = hora2 * 60 * 60;

            duração = inicio - fim;

           
            X = Math.Abs(duração / (60 * 60)); duração = Math.Abs(duração % (60 * 60));
           


           
            Console.WriteLine(X + " hora(s)");
            




           







        }
    }
}
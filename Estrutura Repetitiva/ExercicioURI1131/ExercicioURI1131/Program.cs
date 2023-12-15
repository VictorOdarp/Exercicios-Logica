using System;


namespace URI1131
{

    class Program
    {
        static void Main(string[] args)
        {
            int Inter, Gremio, Grenais, NovoGrenal, GolsInter, GolsGremio, Empate;
            string[] vet;
            Grenais = 0;
            Empate = 0;
            Inter = 0;
            Gremio = 0;
            NovoGrenal = 1;


           
            

            while (NovoGrenal == 1)
            {
                vet = Console.ReadLine().Split(' ');
                GolsInter = int.Parse(vet[0]);
                GolsGremio = int.Parse(vet[1]);
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                NovoGrenal = int.Parse(Console.ReadLine());
               
                if (GolsInter > GolsGremio)
                {
                    Inter++;
                }
                else if (GolsGremio > GolsInter)
                {
                    Gremio++;
                }
                if (GolsInter == GolsGremio)
                {
                    Empate++;
                }
                Grenais++;
                

            }

            if (Inter > Gremio)
            {
                Console.WriteLine(Grenais + " grenais");
                Console.WriteLine("Inter: " + Inter);
                Console.WriteLine("Gremio: " + Gremio);
                Console.WriteLine("Empates: " + Empate);
                Console.WriteLine("Inter venceu mais");
            }
            else if (Gremio > Inter)
            {
                Console.WriteLine(Grenais + " grenais");
                Console.WriteLine("Inter: " + Inter);
                Console.WriteLine("Gremio: " + Gremio);
                Console.WriteLine("Empates: " + Empate);
                Console.WriteLine("Gremio venceu mais");
            }
            else if (Gremio == Inter)
            {
                Console.WriteLine(Grenais + " grenais");
                Console.WriteLine("Inter: " + Inter);
                Console.WriteLine("Gremio: " + Gremio);
                Console.WriteLine("Empates: " + Empate);
                Console.WriteLine("Não houve vencedores");
            }
            

            
        }
    }
}
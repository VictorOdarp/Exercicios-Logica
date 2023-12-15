using System;


namespace URI1101
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N, min, max, soma, soma2;
            string[] vet;
            soma = 0;
            soma2 = 0;


            vet = Console.ReadLine().Split(' ');
            M = int.Parse(vet[0]);
            N = int.Parse(vet[1]); 

            if (M > N )
            {
                min = N;
                max = M;
            }
            else
            {
                min = M;
                max = N;
            }

            while (max > 0 && min  > 0)
            {
                for (int i = 0; soma < max; i++)
                {
                   
                    soma = min + i;
                    Console.Write(soma + " ");
                    soma2 = soma + soma2;
                    
                }
                
                Console.Write("Sum=" + soma2);
                soma = 0;
                soma2 = 0;
                Console.Write("\n");

                vet = Console.ReadLine().Split(' ');
                M = int.Parse(vet[0]);
                N = int.Parse(vet[1]);

                if (M > N)
                {
                    min = N;
                    max = M;
                }
                else
                {
                    min = M;
                    max = N;
                }
            }
            
            
            




        }
    }
}
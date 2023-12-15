using System; 

namespace ExercicioProposto6
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            string[] nome, vet;
            int[] idade;
            
            N = int.Parse(Console.ReadLine());
            nome = new string[N];
            idade = new int[N];
            
            for (int i = 0;  i < N; i++)
            {
                vet = Console.ReadLine().Split(' ');
                nome[i] = (vet[0]);
                idade[i] = int.Parse(vet[1]);
            }

            int maioridade = 0;
            int cont = 0;

            for (int i = 0; i < N; i++)
            {
                if (idade[i] > maioridade)
                {
                    maioridade = idade[i]; 
                    cont++;
                }
            }

            Console.WriteLine("Pessoa mais velha: " + nome[cont]);
        }
    }
}

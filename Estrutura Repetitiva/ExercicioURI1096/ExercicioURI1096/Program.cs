using System;

namespace URI1096
{
    class Program
    {
        static void Main(string[] args)
        {
            int J;
            J = 7; 

            for (int i = 1; i < 10; i++)
            {
                

                Console.WriteLine("I=" + i + " J=" + J);
                J -= 1;
                Console.WriteLine("I=" + i + " J=" + J);
                J -= 1;
                Console.WriteLine("I=" + i + " J=" + J);
                J -= 1;

                i = i + 1;
                
                if (J == 4)
                {
                    J = J = 7;
                }



            }
        }
    }
}
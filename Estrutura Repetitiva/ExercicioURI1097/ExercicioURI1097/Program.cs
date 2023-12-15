using System;


namespace  URI1097
{
    class Program
    {
        static void Main(string[] args)
        {
            int J;
            J = 7; 

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("I=" +  i + " J=" + J);
                J -= 1;
                Console.WriteLine("I=" + i + " J=" + J);
                J -= 1;
                Console.WriteLine("I=" + i + " J=" + J);
                
                

                i = i + 1;

                if (J == 5)
                {
                    J = 9; 
                }
                else if (J == 7)
                {
                    J = 11; 
                }
                else if (J == 9)
                {
                    J = 13;
                }
                else if (J == 11)
                {
                    J = 15;
                }
           

            }
        }
    }
}

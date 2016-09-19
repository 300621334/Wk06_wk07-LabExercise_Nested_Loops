using System;


namespace _06._07
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            string dash = "     ", star = "******";

            do
            {
                Console.WriteLine(dash+star);
                dash = dash + "\b";
                counter++;
            }
            while (counter<=6);
            Console.WriteLine("\n\n\n\n");
            counter = 1;
            do
            {
                Console.WriteLine(dash+star);
                dash = dash + " ";
                counter++;
            }
            while (counter<=6);


        }
    }
}

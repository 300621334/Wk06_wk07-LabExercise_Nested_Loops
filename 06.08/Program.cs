using System;


namespace _06._08
{
    class Program
    {
        static void Main(string[] args)
        {
            string dash = "     ", star = "*";
            int counter = 0;
            Console.WriteLine(dash + star);
            do
            {
                dash = dash + "\b";
                star = star + "**";
                Console.WriteLine(dash + star);
                counter++;
            }
            while (counter < 5);

            counter = 0;

            do
            {
                dash = dash + " ";
                star = star.Substring(0, star.Length - 2);
                Console.WriteLine(dash + star);
                counter++;
            }
            while (counter < 5);

            Console.WriteLine("\n\n\n");


            dash = "     ";  star = "*"; counter = 0;
            string space = "";
            Console.WriteLine(dash + star);
            do
            {
                
                space = space + " ";
                if(space.Length%2!=0)
                {
                    dash = dash + "\b";
                    Console.WriteLine(dash+star+space+star);

                }
                counter++;
            }
            while (counter<7);
            Console.WriteLine("***********");





        }
    }
}

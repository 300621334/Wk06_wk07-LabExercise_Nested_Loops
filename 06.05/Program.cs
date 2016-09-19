using System;
/*5.a to 5.b*/

namespace _06._05
{
    class Program
    {
        static void Main(string[] args)
        {
            string dash = "-----", star = "*";
            int counter = 0;
            Console.WriteLine("-----*");
            do
            {
               dash = dash + "\b";
               star = star + "**";
                Console.WriteLine(dash+star);
                counter++;
            }
            while (counter<5);


            counter = 0;
            star = "*";
            Console.WriteLine(star);
            do
            {
                star = " "+star;
                Console.WriteLine(star);
                counter++;
            }
            while (counter<6);


        }
    }
}

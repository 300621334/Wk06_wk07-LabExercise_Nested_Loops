using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._06
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string spaces = "     ", star="*";
            
            do
            {
                Console.WriteLine(spaces + star);
                spaces = spaces+"\b";
               counter++;
            }
            while (counter < 5);


            spaces = "     ";
            counter = 0;
            do
            {
                Console.WriteLine(spaces + star);
                spaces = spaces + "\b";
                star = star +"*";
                counter++;
            }
            while (counter < 5);
        }
    }
}

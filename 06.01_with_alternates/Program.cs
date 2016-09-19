using System;
/*1.Print the decimal, octal, and hexadecimal values of all characters between the start and stop characters entered by a user. 
 * For example, if the user enters an a and z, the program should print all the characters between a and z and their respective numerical values. 
 * Make sure that the second character entered by the user occurs later in the alphabet than the first character. 
 * If it does not, write a loop that repeatedly asks the user for a valid second character until one is entered.
Your output should be formatted as shown below
Letter	Decimal	Octal	Hex
a		97	    141	    61
b		98	    142	    62
c		99	    143	    63
d		100	    144	    64
e		101	    145	    65
*/

namespace _06._01
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            char letter, letterEnd;
            bool wasItChar1, wasItChar2;

            do
            {
                Console.WriteLine("Enter starting letter:");
                //letter = Convert.ToChar(Console.ReadLine());
                wasItChar1 = char.TryParse(Console.ReadLine(), out letter);
            }
            while (!wasItChar1);

            do
            {
                Console.WriteLine("Enter ending letter:");
                //letterEnd = Convert.ToChar(Console.ReadLine());
                wasItChar2 = char.TryParse(Console.ReadLine(), out letterEnd);
            }
            while (wasItChar2 == false || letterEnd < letter);



            //while (letterEnd < letter)
            //    {
            //        Console.WriteLine("Enter ending letter:");
            //        letterEnd = Convert.ToChar(Console.ReadLine());
            //    }

            Console.WriteLine("Letter   Decimal   Octal   Hex");

            do
            {
                num = (int)letter;
                Console.WriteLine("{0}        {1}        {2}      {3}", letter, num, Convert.ToString(num, 16), Convert.ToString(num, 8));
                num++;
                letter = (char)num;
            }
            while (letterEnd >= letter);


            //Console.WriteLine("Enter a letter");
            //char letter = Convert.ToChar(Console.ReadLine());
            //int num = (int)letter;
            //convert to HEX with ":x"--or-- using convert.toString(to be converted, convert to HEX 16 or Oct 8)
            //Console.WriteLine("{0:x}", num);
            //Console.WriteLine("Decimal representation of letter is {0}", num);
            //Console.WriteLine("Hexadecimal for letter is {0}", Convert.ToString(num, 16));
            //Console.WriteLine("Octal for letter is {0}", Convert.ToString(num, 8));



        }
    }
}

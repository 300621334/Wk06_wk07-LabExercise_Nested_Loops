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
            //something wrong with "for" loop. writes first char twice if "letter = (char)num" is inside block. but when inside "For()" then it works fine.
            //int num = 0;
            //char letter, letterEnd;
            //bool wasItChar1, wasItChar2;

            //do
            //{
            //    Console.WriteLine("Enter starting letter:");
            //    wasItChar1 = char.TryParse(Console.ReadLine(), out letter);
            //}
            //while (wasItChar1 == false);

            //do
            //{
            //    Console.WriteLine("Enter ending letter:");
            //    wasItChar2 = char.TryParse(Console.ReadLine(), out letterEnd);
            //}
            //while (wasItChar2 == false || letterEnd < letter);


            //Console.WriteLine("Letter   Decimal   Hex   Octal");

            //for (num = (int)letter; letterEnd >= letter; num++, letter = (char)num /*letter++*/)
            //{
            //Console.WriteLine("{0,2}   {1,5}      {2,3}      {3,3}", letter, (int)letter, Convert.ToString(num/*(int)letter*/, 16), Convert.ToString(num/*(int)letter*/, 8));
            //}








            int num = 0;
            char letter, letterEnd;
            bool wasItChar1, wasItChar2;

            do
            {
                Console.WriteLine("Enter starting letter:");
                wasItChar1 = char.TryParse(Console.ReadLine(), out letter);
            }
            while (wasItChar1 == false);

            do
            {
                Console.WriteLine("Enter ending letter:");
                wasItChar2 = char.TryParse(Console.ReadLine(), out letterEnd);
            }
            while (wasItChar2 == false || letterEnd < letter);

            Console.WriteLine("Letter   Decimal   Hex   Octal");

            do
            {
                num = (int)letter;
                Console.WriteLine("{0,2}   {1,5}      {2,3}      {3,3}", letter, num, Convert.ToString(num, 16), Convert.ToString(num, 8));
                letter++;
            }
            while (letterEnd >= letter);








            //int num = 0;
            //char letter, letterEnd;
            //bool wasItChar1, wasItChar2;

            //do
            //{
            //    Console.WriteLine("Enter starting letter:");
            //    wasItChar1 = char.TryParse(Console.ReadLine(), out letter);
            //}
            //while (wasItChar1 == false);

            //do
            //{
            //    Console.WriteLine("Enter ending letter:");
            //    wasItChar2 = char.TryParse(Console.ReadLine(), out letterEnd);
            //}
            //while (wasItChar2 == false || letterEnd < letter);

            //Console.WriteLine("Letter   Decimal   Hex   Octal");

            //do
            //{
            //    num = (int)letter;
            //    Console.WriteLine("{0,2}   {1,5}      {2,3}      {3,3}", letter, num, Convert.ToString(num, 16), Convert.ToString(num, 8));
            //    num++;
            //    letter = (char)num;
            //}
            //while (letterEnd >= letter);


        }
    }
}

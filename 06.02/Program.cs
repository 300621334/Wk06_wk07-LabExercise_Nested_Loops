using System;
/*2.Write a program to reverse the digits of a positive integer number. For example, if the number 8735 is entered, the number displayed should be 5378. 
 * (Hint: Use a do statement and continuously strip off and display the units digit of the number. If the variable num initially contains the number entered, 
 * the units digit is obtained as (num % 10). After a units digit is displayed, dividing the number by 10 sets up the number for the next iteration. 
 * Thus, (8735 % 10) is 5 and (8735 / 10) is 873. The do statement should continue as long as the remaining number is not zero).*/

namespace _06._02
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1, num2 = 0;
            Console.WriteLine("Enter a positive integer:");
            //e.g. number is 8765
            num1 = Convert.ToInt32(Console.ReadLine());

            for (; num1 > 0; )
            {
                num2 = num1 % 10;
                num1 = num1 / 10;
                Console.Write(num2);
            }
            




            //int num1, num2=0;
            //Console.WriteLine("Enter a positive integer:");
            ////e.g. number is 8765
            //num1 = Convert.ToInt32(Console.ReadLine());
            //do
            //{
            //    num2 = num1%10;
            //    num1 = num1/10;
            //    Console.Write(num2);
            //}
            //while(num1>0);

            

        }
    }
}

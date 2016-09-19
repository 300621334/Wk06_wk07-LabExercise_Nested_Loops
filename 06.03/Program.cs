using System;
/*3.Write a C# program that calculates and displays the yearly amount available if $1,000 is invested in a bank account for 10 years. 
Your program should display the amounts available for interest rates from 6 percent to 12 percent inclusively, at 1 percent increments. 
Use a nested loop, with the outer loop having a fixed count of 7 and the inner loop a fixed count of 10. The first iteration of the outer 
loop should use an interest rate of 6 percent and display the amount of money available at the end of the first 10 years. 
In each subsequent pass through the outer loop, the interest rate should be increased by 1 percent. Use the relationship that 
the money available at the end of each year equals the amount of money in the account at the start of the year plus the interest
rate times the amount available at the start of the year. The output of this program should be in the form of a table.
(Rate for first 10 Y is 6%, next 10Y 7% , next 10Y 8% and so-on…)
*/

namespace _06._03
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance=1000, rate=6, counter=1, years=1;
            Console.WriteLine("End Of Year --- Interest Rate --- Balance");
            Console.WriteLine("===========     =============     =======");

            do
            {
                do
                {

                    balance = balance + (balance * rate/100);
                    Console.WriteLine("{0, -16}{1, -18}{2:c2}", years, rate, balance);
                    counter++;
                    years++;
                }
                while (counter<=10);                                     

                rate++;
                counter = 1;
            }
            while (rate<=12);
        }
    }
}

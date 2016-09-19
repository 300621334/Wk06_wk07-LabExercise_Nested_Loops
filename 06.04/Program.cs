using System;
/*4.b.Modify the program written for Question 3 to initially prompt the user for both the amount of money initially deposited and the number of years that should be displayed. 
*/

namespace _06._04
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance, rate = 6, counter = 1, years = 1, numberOfYears;

            Console.WriteLine("Enter intial deposit:");
            balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter number of years to display:");
            numberOfYears = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("End Of Year --- Interest Rate --- Balance");
            Console.WriteLine("===========     =============     =======");


            do
            {
                while (counter <= 10 && years <= numberOfYears)
                {
                    balance = balance + (balance * rate / 100);
                    Console.WriteLine("{0, -16}{1, -18}{2:c2}", years, rate, balance);
                    counter++;
                    years++;
                }

                rate++;
                counter = 1;
            }
            while (rate <= 12);
            //or to avoid outer looping to go on till rate<=12, type:- while (rate <= 12 && years <= numberOfYears);



        }
    }
}

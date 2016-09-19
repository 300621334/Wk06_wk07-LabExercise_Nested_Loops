using System;
/*user enter 2 # & find sum of multiples of 7 between them*/

namespace class_task_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1=0, num2=0, start=0, end=0, sum=0;

            Console.Write("Enter First Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if(num1<num2)
            {
                start = num1;
                end = num2;
            }
            else if(num2<num1)
            {
            start = num2;
            end = num1;
            }
            
            for (;start <= end;start++)
            {
                if(start % 7==0)
                {
                     sum+=start;
                }
            }
            //for (; num1 >= num2; num1--)
            //{
            //    if (num1 % 7 == 0)
            //    {
            //        multiple += num1;
            //    }

            //}

               

            Console.WriteLine("Sum is {0}",sum);
        }
    }
}

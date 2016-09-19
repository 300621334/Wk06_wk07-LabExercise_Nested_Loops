using System;
/*
00 01 02 03 04 05 06 07 08 09 010
10 11 12 13 14 15 16 17 18 19 110
20 21 22 23 24 25 26 27 28 29 210
30 31 32 33 34 35 36 37 38 39 310
40 41 42 43 44 45 46 47 48 49 410
50 51 52 53 54 55 56 57 58 59 510

*/

namespace _7.b
{
    class Program
    {
        static void Main(string[] args)
        {
            string star = "*";
            for (int row = 0; row < 6; row++)
            {
                for (int col = 0; col < 11; col++)
                {
                    if (row + col == 5 || col - row == 5)
                    {
                        Console.Write("*");
                    }
                    else if (row == 5)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();

            }

            for (int row = 1; row < 6; row++)
            {
                for (int col = 0; col < 10; col++)
                {
                    if (row == col || row + col == 10)
                    {
                        Console.Write("*");
                    }
                    
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

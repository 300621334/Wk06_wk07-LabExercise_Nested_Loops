using System;
/*
00 01 02 03 04 05
10 11 12 13 14 15
20 21 22 23 24 25
30 31 32 33 34 35
40 41 42 43 44 45
50 51 52 53 54 55
60 61 62 63 64 65
 */

namespace _04.d
{
    class Program
    {
        static void Main(string[] args)
        {for (int row = 0; row < 7; row++)
            {
                for (int col = 0; col < 6; col++)
                {
                    if (row==0 ||col==0 || row==6 || col==5)
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

using System;
/*
00 01 02 03 04 05
10 11 12 13 14 15
20 21 22 23 24 25
30 31 32 33 34 35
40 41 42 43 44 45
50 51 52 53 54 55

*/

namespace _6.b
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int row = 0; row < 6; row++)
            {
                for (int col = 0; row>col; col++)
                {
                    Console.Write(" ");

                }
                for (int counter = 0; counter < 6; counter++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

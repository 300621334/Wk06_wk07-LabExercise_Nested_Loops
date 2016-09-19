using System;
/*
00 01 02 03 04 05 06 07
10 11 12 13 14 15 16 17
20 21 22 23 24 25 26 27
30 31 32 33 34 35 36 37
40 41 42 43 44 45 46 47
50 51 52 53 54 55 56 57
60 61 62 63 64 65 66 67
70 71 72 73 74 75 76 77
*/

namespace _6.a
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int row = 0; row < 6; row++)
            {
                for (int col = 0; row+col<5; col++)
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

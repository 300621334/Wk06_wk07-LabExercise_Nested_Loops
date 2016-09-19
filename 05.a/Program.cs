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

namespace _05.a
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    //if (row == 7 || col == 7 || row+col==7 || row+col==8 || row+col==9 || row+col==10 || row+col==11 || row+col==12)
                    if (row == 7 || col == 7 || (row + col >= 7 && row+col<=12))
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

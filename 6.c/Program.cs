using System;
/*
00 01 02 03 04
10 11 12 13 14
20 21 22 23 24
30 31 32 33 34
40 41 42 43 44
50 51 52 53 54
*/

namespace _6.c
{
    class Program
    {
        static void Main(string[] args)
        {
            /*for (int row=0;row<6;++row)
            {
                for (int col = 0; col < 11; ++col)
                {
                    if (row+col<5)
                        Console.Write("-");
                    else
                    {
                        for (;col - row <= 5; col++)
                        {
                            Console.Write("*");
                        }
                    }
                }
                
                Console.WriteLine();
                //star += "**";
            }
            */
            string star = "*";

            for (int row = 0; row < 6; row++)
            {
                
                for (int col = 0; row+col<5; col++)
                {
                    Console.Write("-");
                }
                
                    Console.WriteLine(star);
                    star += "**";
            }
        }
    }
}

using System;
/*5.b.
 
00 01 02 03 04 05 06 07
10 11 12 13 14 15 16 17
20 21 22 23 24 25 26 27
30 31 32 33 34 35 36 37
40 41 42 43 44 45 46 47
50 51 52 53 54 55 56 57
60 61 62 63 64 65 66 67
70 71 72 73 74 75 76 77



*/

namespace _06._05_TeachersMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int row = 0; row < 7; row++)
            //{
            //    for (int col = 0; col < 6; col++)
            //    {
            //        if (row == col || row + col == 5)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //    }
            //    Console.WriteLine();
            //}



            //for (int row = 0; row < 7; row++)
            //{
            //    for (int col = 0; col < 7; col++)
            //    {
            //        if (row + col == 5)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //    }
            //    Console.WriteLine();
            //}



            //for (int row = 0; row < 7; row++)
            //{
            //    for (int col = 0; col < 6; col++)
            //    {
            //        if(row==col)
            //        {
            //        Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //    }
            //    Console.WriteLine();
            //}



            //for (int row = 0; row < 7; row++)
            //{
            //    for (int col = 0; col < 6; col++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}



            /*
            99 98 97 96 95 94 93 92 91
            89 88 87 86 85 84 83 82 81
            79 78 77 76 75 74 73 72 71
            69 68 67 66 65 64 63 62 61
            59 58 57 56 55 54 53 52 51
            49 48 47 46 45 44 43 42 41
            39 38 37 36 35 34 33 32 31
            29 28 27 26 25 24 23 22 21
            19 18 17 16 15 14 13 12 11
            */
            for (int row = 9; row > 0; row--)
            {
                for (int col = 9; col > 0; col--)
                {
                    Console.Write("{0}{1} ", row, col);
                }
                Console.WriteLine();
            }


            //for(int row=0;row<6;row++)
            //{
            //    for (char col ='a' ;col<'g';col++)
            //    {
            //        Console.Write("{0}{1} ",row, col);
            //    }
            //    Console.WriteLine();
            //}

        }
    }
}

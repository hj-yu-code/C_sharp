using System;
/*
    grid
    (2000)
    ----------------
    [0      1]
    (3000)  (4000)
    2000    2004

    [0      1]          [0      1       2       3]
    (10)    (20)        (100)   (200)   (300)   (400)
    3000    3004        4000    4004    4008    4012
 */
namespace ch10
{
    class Array_Jagged배열
    {
        static void Main(string[] args)
        {
            // c/c++ 이중포인터와 유사
            int[][] grid = new int[2][]; // 톱니바퀴 배열(=jagged 배열)
            grid[0] = new int[3];
            grid[1] = new int[4];

            grid[0][0] = 10;
            grid[0][1] = 20;

            grid[1][0] = 100;
            grid[1][1] = 200;
            grid[1][2] = 300;
            grid[1][3] = 400;

            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine("{0}, ", grid[0][i]);
            }
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("{0}, ", grid[1][i]);
            }
        }
    }
}

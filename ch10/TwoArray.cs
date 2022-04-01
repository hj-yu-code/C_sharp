using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch10
{
    class TwoArray
    {
        static void Main()
        {
            int[,] grid = new int[2, 3]; // 2행 3열
            grid[0, 0] = 10;
            grid[0, 1] = 20;
            grid[1, 0] = 30;
            grid[1, 1] = 40;

            int[,] grid2 = new int[2, 3]
            {
                {1, 2, 3 },
                {4, 5, 6 }
            };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write(" {0}, ", grid[i, j]);
                Console.WriteLine();
            }

            //int[,] grid3 = new int[2, 3] // 배열 초기화에서 배열 원소의 수는 배열 행열 수와 같아야 함
            //{
            //    {1, 2},
            //    {4, 5 }
            //};

            //int[,] grid4 = new int[2, 3]
            //{
            //    {1, 2, 3, 4, 5, 6 }; // 배열 초기화는 행단위 {}를 생략할 수 없음
            //};
        }
    }
}

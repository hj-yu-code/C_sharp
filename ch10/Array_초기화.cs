using System;

namespace ch10
{
    class Array_초기화
    {
        static void Main(string[] args)
        {
            int[] row1 = new int[3] { 1, 2, 3 };
            int[] row2 = new int[] { 1, 2, 3 };
            int[] row3 = { 10, 20, 30 };

            for(int i = 0; i <row3.Length; i++)
            {
                Console.WriteLine("{0}, {1}, {2}", row1[i], row2[i], row3[i]);
            }

            int[] row4;
            row4 = new int[4] { 1, 2, 3, 4 };
            int[] row5 = new int[4];

            for (int i = 0; i < row4.Length; i++)
            {
                Console.WriteLine("{0}, {1}", row4[i], row5[i], row3[i]);
            }
            int[] row6;
            //row6 = { 1, 2, 3, 4, 5 }; // 대입문

            //int[] row7 = new int[2] {1}; // 초기화 원소의 수는 할당메모리 크기의 개수와 같아야 함
            //int[] row8 = new int[2] { };

        }
    }
}

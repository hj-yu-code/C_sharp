using System;

namespace ch10
{
    class ArrayPropertis
    {
        static void Main()
        {
            int[] a = new int[10];
            int[,] b = new int[10, 10];
            int[,,] c = new int[10, 10, 10];
            int[][] d = new int[2][];

            d[0] = new int[3];
            d[1] = new int[5];

            // Rank : 차원을 보여주는 매소드
            Console.WriteLine("a.Rank {0}", a.Rank); // 1
            Console.WriteLine("b.Rank {0}", b.Rank); // 2
            Console.WriteLine("c.Rank {0}", c.Rank); // 3
            Console.WriteLine("d.Rank {0}", d.Rank); // 1
            Console.WriteLine();

            // Length : 배열의 크기(갯수)
            Console.WriteLine("a.Length {0}", a.Length); // 10
            Console.WriteLine("b.Length {0}", b.Length); // 100
            Console.WriteLine("c.Length {0}", c.Length); // 1000 
            Console.WriteLine("d.Length {0}", d.Length); // 2
            Console.WriteLine("d[0].Length {0}", d[0].Length); // 3
            Console.WriteLine("d[1].Length {0}", d[1].Length); // 5
            Console.WriteLine();

            // GetLength : 행렬의 크기(갯수)
            Console.WriteLine("b.GetLength(0) {0}", b.GetLength(0)); // 10
            Console.WriteLine("b.GetLength(1) {0}", b.GetLength(1)); // 10

        }
    }
}

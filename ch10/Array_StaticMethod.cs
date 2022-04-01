using System;

namespace ch10
{
    class Array_StaticMethod
    {
        static void PrintArray(int[] arr)
        {
            Console.WriteLine();
            foreach (int n in arr)
                Console.Write("{0}, ", n);
            Console.WriteLine();

        }

        // Array 클래스가 제공해주는 매서드 : 정적매서드
        static void Main(string[] args)
        {
            int[] arr1 = { 20, 10, 50, 64, 90, 74, 4, 90, 4, 100 };
            PrintArray(arr1);

            Array.Clear(arr1, 0, arr1.Length); // 초기화
            PrintArray(arr1);

            int[] arr2 = { 20, 10, 50, 64, 90, 74, 4, 90, 4, 100 };
            int[] arr3 = new int[arr2.Length];

            Array.Copy(arr2, arr3, arr2.Length); // 복사
            PrintArray(arr3);

            Array.Clear(arr3, 0, arr3.Length);
            Array.Copy(arr2, 5, arr3, 5, 3);
            PrintArray(arr3); // 0, 0, 0, 0, 0, 74, 4, 90, 0, 0,

            PrintArray(arr2);
            int N = Array.IndexOf(arr2, 90); // not found : -1
            Console.WriteLine("{0}, {1}", N, arr2[N]); // 4, 90

            Array.Sort(arr2); // 오름차순
            PrintArray(arr2); // 4, 4, 10, 20, 50, 64, 74, 90, 90, 100,
            Array.Reverse(arr2); // 내림차순
            PrintArray(arr2); // 100, 90, 90, 74, 64, 50, 20, 10, 4, 4,

        }
    }
}

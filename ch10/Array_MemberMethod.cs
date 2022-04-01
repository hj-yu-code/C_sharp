using System;

namespace ch10
{
    class Array_MemberMethod
    {
        static void Main()
        {
            int[] data1 = { 10, 10 };
            int[] copy = data1; // 참조(shallow copy)

            copy[0]++;
            copy[1]++;

            foreach (int n in data1)
                Console.Write("{0}, ", n); // 11, 11,
            Console.WriteLine();

            int[] data2 = { 10, 10 };
            int[] copy2 = (int[])data2.Clone(); // 복제(deep copy)
            copy2[0]++;
            copy2[1]++;

            foreach (int n in data2)
                Console.Write("{0}, ", n); // 10, 10,
            Console.WriteLine();

            int[] data3 = { 10, 10 };
            int[] copy3 = new int[5];
            data3.CopyTo(copy3, 2); // 2열부터 복사
            // 원소대 원소로 내용 복사 (deep copy)

            foreach (int n in copy3)
                Console.Write("{0}, ", n); // 0, 0, 10, 10, 0,
            Console.WriteLine();

        }
    }
}

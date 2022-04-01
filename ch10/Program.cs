using System;

namespace ch10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("배열");
            int[] x = new int[5]; //  선언과 동시에 메모리 할당

            int[] y; // 배열 변수 선언
            y = new int[5]; // 메모리 할당하여 y가 참조

            x[0] = 10;
            x[1] = 20;
            x[2] = 30;
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write("{0}, ", x[i]);
            }
            Console.WriteLine();

            int[] z;
            z = x; // shallow copy (주소만 복사)
            for(int i=0; i < x.Length; i++)
            {
                Console.Write("{0}, ", z[i]); // 10, 20, 30, 0, 0,
            }
            Console.WriteLine();

            z[0] = 100;
            z[1] = 200;
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write("{0}, ", x[i]); // 100, 200, 30, 0, 0,
            }
            Console.WriteLine();

            int n = 5;
            int[] a5 = new int[n]; // ok, 변수로 배열크기 선언 가능

            // 문법 오류
            //int[5] a1;        // 갯수는 new 뒤에 작성
            //int a2[5];        // c/c++ 문법 사용 불가
            //int[] a3 = new int[-5]; // 음수는 작성 불가
            //int[] a3 = new int[];   // new 뒤에 크기는 필수


        }
    }
}

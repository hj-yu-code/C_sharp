using System;

namespace ch01
{
    class Nullable
    {
        public static void Main()
        {
            // [변수]? : null 을 저장할 수 있는 변수
            int? a= null;
            int b = 0;

            Console.WriteLine(a.HasValue); // False
            // HasValue : 값을 가지고 있으면 True
            Console.WriteLine(a != null); // False
            Console.WriteLine(a); // (없음)
            Console.WriteLine(b); // 0

            a = 100;
            Console.WriteLine(a.HasValue); // True
            Console.WriteLine(a != null); // True
            Console.WriteLine(a); // 100
            Console.WriteLine();


            // Var type 변수
            // 컴파일러가 자동으로 해당 변수의 형식을 지정
            // 메모리가 너무 많이 소모(오버헤드 발생)
            int num = 100;
            Console.WriteLine("{0}, {1}", num, num.GetType()); // 100, System.Int32

            // var type 변수는 값이 저장될 때 자료형이 결정
            var Tmp = 200; // 초기화 필수
            Console.WriteLine("{0}, {1}", Tmp, Tmp.GetType()); // 100, System.Int32

            var Tmp2 = 3.4;
            Console.WriteLine("{0}, {1}", Tmp2, Tmp2.GetType());

            var Tmp3 = "campus";
            Console.WriteLine("{0}, {1}", Tmp3, Tmp3.GetType()); // campus, System.String

            var Tmp4 = new int[] { 10, 20, 40 };
            Console.WriteLine("{0}, {1}", Tmp4, Tmp4.GetType()); // System.Int32[], System.Int32[]

        }
    }
}

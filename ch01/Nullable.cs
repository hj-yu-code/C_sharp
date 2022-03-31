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
            int num = 100;
            Console.WriteLine("{0}, {1}", num, num.GetType()); // 100, System.Int32

            var intTmp = 200;
            Console.WriteLine("{0}, {1}", intTmp, intTmp.GetType()); // 100, System.Int32

        }
    }
}

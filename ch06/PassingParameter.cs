using System;

namespace ch06
{
    class PassingParameter
    {
        static void PassByVal(int x, int y)
        {
            x++;
            y++;
        }
        static void PassByRef(ref int x, ref int y)
        {
            x++;
            y++;
        }
        static void PassByOut(out int x, out int y)
        {
            // out 키워드 : 기존값을 사용할수 없고, 저장만 가능
            //x++;
            //y++;
            x = 30;
            y = 40;
        }
        static void Main(string[] args)
        {
            int a1 = 10, b1 = 20;
            int a2 = 10, b2 = 20;
            int a3 = 10, b3 = 20;

            PassByVal(a1, b1); // 값만 들어가는 것
            Console.WriteLine("a1: {0}, b1: {1}", a1, b1); // a1: 10, b1: 20

            PassByRef(ref a2, ref b2); // ref는 참조자와 비슷
            Console.WriteLine("a2: {0}, b2: {1}", a2, b2); // a2: 11, b2: 21

            PassByOut(out a3, out b3);
            Console.WriteLine("a3: {0}, b3: {1}", a3, b3); // a3: 30, b3: 40

        }
    }
}

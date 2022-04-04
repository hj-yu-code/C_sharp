using System;

namespace ch07
{
    class Point
    {
        public double x;
        public double y;
    }
    class Class_ReferenceParameter
    {
        static void PassByVal(Point _c1)
        {
            Console.WriteLine("_c1 : {0}, {1}", _c1.x, _c1.y);
            _c1.x++;
            _c1.y++;
            _c1 = new Point();
        }
        static void PassByRef(ref Point _c1)
        {
            Console.WriteLine("_c1 : {0}, {1}", _c1.x, _c1.y);
            _c1.x++;
            _c1.y++;

            _c1 = new Point();
        }
        static void PassByOut(out Point _c2)
        {
            _c2 = new Point();
            _c2.x = 5.5;
            _c2.y = 5.5;
        }

        static void Main(string[] args)
        {
            Point c1 = new Point();
            c1.x = 1.0;
            c1.y = 1.5;
            PassByVal(c1); // 메모리를 따로 받음
            Console.WriteLine("PassByVal : {0}, {1}", c1.x, c1.y); // 2, 2.5

            PassByRef(ref c1); // 같은 메모리를 가르킴
            // 바뀌기 전 내용은 그대로 남아있긴 함
            Console.WriteLine("PassByRef : {0}, {1}", c1.x, c1.y); // 0, 0

            Point c2;
            PassByOut(out c2); // 저장용
            Console.WriteLine("PassByOut : {0}, {1}", c2.x, c2.y); // 5.5, 5.5
        }


    }
}

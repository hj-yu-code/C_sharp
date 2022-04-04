using System;

namespace CH07
{
    class Point
    {
        public double x; //멤버변수
        public double y;

    }
    class Class_Intor
    {
        static void Main(string[] args)
        {
            Point c1 = new Point();
            Point c2 = new Point();
            Point c3;

            c1.x = 1.0;
            c1.y = 1.5;
            c2.x = 2.0;
            c2.y = 2.5;

            Console.WriteLine("c1 : {0}, {1}", c1.x, c1.y);
            Console.WriteLine("c1 : {0}, {1}", c2.x, c2.y);

            c3 = c1; // 주소만 복사

            if (c1 == c2)
                Console.WriteLine("Equal !!!");
            else
                Console.WriteLine(" Not Equal !!!");
            if (c1 == c3)
                Console.WriteLine("Equal !!!");
            else
                Console.WriteLine(" Not Equal !!!");

            c3.x = 3.0;
            c3.x = 3.5;

            Console.WriteLine("c1 : {0}, {1}", c1.x, c1.y);

            // 객체를 참조하는 reference count 를 감소하여 0 이되면, GC가 더 빠른 해제를 유도함
            c1 = null; //객체를 참조하는 reference 
            c2 = null; //동적 할당은 가비지 컬렉터가 자동으로 해제한다
            c3 = null;

        }
    }
}

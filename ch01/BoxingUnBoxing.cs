using System;
/*
    a       b       c
    (123)   (3000)  (123)
    ---------------
            (123)
            [3000]
*/
namespace ch01
{
    class BoxingUnBoxing
    {
        public static void Main()
        {
            int a = 123;
            object b = (object)a; // Boxing
            Console.WriteLine(a);
            Console.WriteLine(b);
            // Boxing : stack에 있는 내용을 heap에 넣음

            int c = (int)b; // UnBoxing
            Console.WriteLine(b);
            Console.WriteLine(c);
            // UnBoxing : heap에 있는 내용을 stack에 넣음

        }
    }
}

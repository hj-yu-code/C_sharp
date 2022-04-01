using System;

namespace ch06
{
    class MethodOverloading
    {
        static int Add(int x, int y)
        {
            return x + y;
        }
        static double Add(double x, double y)
        {
            return x + y;
        }
        static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            int ret = Add(10, 20);
            Console.WriteLine("ret : {0}", ret);

            double ret2 = Add(1.1, 2.1);
            Console.WriteLine("ret2 : {0}", ret2);

            decimal ret3 = Add(100, 200);
            Console.WriteLine("ret3 : {0}", ret3);
        }


    }
}

using System;

namespace ch01
{
    class SimpleType2
    {
        public static void Main()
        {
            int x1 = 100;
            Console.WriteLine(x1);

            uint x2 = (uint)x1; // 명시적 형변환 필요
            Console.WriteLine(x2);
            Console.WriteLine();


            x1 = -100;
            x2 = (uint)x1; // 부호비트도 숫자로 봄
            Console.WriteLine(x1); // -100
            Console.WriteLine(x2); // 4294967196
            Console.WriteLine();

            int num = 500;
            float fnum = 1.5F;

            string s1 = num.ToString(); // 값을 문자열로 변경
            string s2 = fnum.ToString();
            string s3 = 100.ToString();
            string s4 = 3.15.ToString();
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine();

            Console.WriteLine("{0}, {1}", num.GetType(), s1.GetType());

            int n1 = Int32.Parse(s1); // 문자열을 값으로 변경
            int n2 = Int32.Parse("200");
            Double f1 = Double.Parse("1.9");
            bool b1 = Boolean.Parse("true");

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(f1);
            Console.WriteLine(b1);
            Console.WriteLine();

            Console.WriteLine("{0}, {1}", n1.GetType(), b1.GetType());


        }
    }
}

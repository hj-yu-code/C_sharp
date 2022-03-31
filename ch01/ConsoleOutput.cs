using System;

namespace ch01
{
    class ConsoleOutput
    {
        public static void Main()
        {
            // WriteLine
            Console.WriteLine(100);
            Console.WriteLine("Hello");
            Console.WriteLine('가');
            Console.WriteLine(3.4);

            // Parameter
            Console.WriteLine("{0}, {1}, {2}", 100, 200, 300);
            Console.WriteLine("{0}, {1}, {1}, {1}, {2}", 100, 200, 300); // 100, 200, 200, 200, 300
            // 인자에 따라 여러번 사용 가능
            Console.WriteLine();

            // Alignment & Format
            Console.WriteLine("{0, -10}", 999); // 왼쪽정렬: 999
            Console.WriteLine("{0, 10}", 999);  // 오른쪽정렬:        999
            Console.WriteLine("{0:C}", 123456789); // 화폐단위 : \123,456,789
            Console.WriteLine("{0:N}", 123456789); // 123,456,789.00
            Console.WriteLine("{0:N0}", 123456789); // 123,456,789
            Console.WriteLine("{0:X}", 123456789); // 16진수 : 75BCD15
            Console.WriteLine();

            Console.WriteLine("{0}", 0); // 0
            Console.WriteLine("{0:#,###}", 0); // (없음)
            Console.WriteLine("{0:#,##0}", 0); // 0
            Console.WriteLine("{0:#,###}", 123456789); // 123,456,789
            Console.WriteLine("{0:#,##0}", 123456789); // 123,456,789
            Console.WriteLine();

            decimal tmp = 20.5M;
            string s = string.Format("온도 {0} 입니다.", tmp); // Format : 문자열을 만들어서 보관하는 함수
            Console.WriteLine(s);

            //Special String
            //Console.WriteLine("\\server\share"); // \ : 특수문자
            Console.WriteLine("\\\\server\\share"); // \\server\share
            Console.WriteLine(@"\\server\share"); // \\server\share << @: 특수문자 제거

        }
    }
}

using System;

namespace PrimtiveTypes
{
    class SimpleType1
    {
        public static void Main()
        {
            // integer type
            sbyte sbyte1 = 127;
            byte byte2 = 250;
            int int3 = 3500000;
            //Int32 int3 = 3500000; // CTS 형식
            long longInt4 = 2700000000;
            int 나이 = 30;

            Console.WriteLine(sbyte1);
            Console.WriteLine(byte2);
            Console.WriteLine(int3);
            Console.WriteLine(longInt4);
            Console.WriteLine(나이); // 한글변수 가능
            Console.WriteLine();

            // real type
            float float5 = 1.123F; // 접미사 F 필수
            double double6 = 3.14159;
            decimal decimal7 = 123.4567M; // 접미사 M 필수

            Console.WriteLine(float5);
            Console.WriteLine(double6);
            Console.WriteLine(decimal7);
            Console.WriteLine();

            // character type
            char char8 = 'A';
            string string9 = "campus";
            bool bool10 = true;

            Console.WriteLine(char8);
            Console.WriteLine(string9);
            Console.WriteLine(bool10);
            Console.WriteLine();

            // 자료형의 크기만 sizeof() 로 확인
            Console.WriteLine("{0}, {1}, {2}", sizeof(bool), sizeof(char), sizeof(decimal)); // 1, 2, 16

            // 변수명의 크기는 sizeof() 로 제공하지 않음
            //Console.WriteLine("{0}, {1}, {2}", sizeof(bool10), sizeof(char8), sizeof(decimal7));

        }
    }
}

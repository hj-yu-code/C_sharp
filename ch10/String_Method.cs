using System;

namespace ch10
{
    class String_Method
    {
        static void Main()
        {
            string s1 = "Hello";
            Console.WriteLine(s1);
            s1 = "World"; // 새로운 동적할당의 주소를 s1에 저장
            Console.WriteLine(s1);

            string s2 = "C is great !";
            string s3 = s2.Insert(1, "#");
            Console.WriteLine(s2); // C is great !
            Console.WriteLine(s3); // C# is great !

            int len = s3.Length;
            Console.WriteLine("문자열 길이 : {0}", len);

            string s4 = string.Copy(s1);
            Console.WriteLine(s4); 

            string s5 = s4; // deep copy : string 자료형 특징
            Console.WriteLine(s4); // World
            Console.WriteLine(s5); // World
            s4 = "campus";
            Console.WriteLine(s4); // campus
            Console.WriteLine(s5); // World

            string s6 = string.Concat("one", "two", "three"); // 문자열을 이어줌
            Console.WriteLine(s6);

            string s7 = string.Concat("multi", s4);
            Console.WriteLine(s7);

            string s8 = "Hello World!!!";
            int n1 = s8.IndexOf("World"); // not found : -1
            Console.WriteLine("s8.IndexOf(\"World\"): {0}", n1); // 6

            string a1 = "Apple";
            string a2 = "apple";

            if (a1 == a2)
                Console.WriteLine("equal!");
            else
                Console.WriteLine("not equal!"); // 대소문자는 다름

            if(a1.ToUpper().Equals(a2.ToUpper()))
                Console.WriteLine("equal!");
            else
                Console.WriteLine("not equal!");

            int n2 = string.Compare(a1, a2, true); // compare : 2개의 문자를 비교해서 같으면 0 반환
            // true : 대소문자 구별 안함
            // false :  대소문자 구별
            Console.WriteLine("string.Compare(a1, a2, true): {0}", n2); // 0

            string a3 = s8.Substring(0, 5); // index 0 ~ index 5
            Console.WriteLine(a3); // Hello

        }
    }
}

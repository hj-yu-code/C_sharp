using System;

namespace ch06
{
    class Program
    {
        static int salary = 3500000;
        // 객체가 생성되기 전에 사용하므로 static 필수!

        static void funcA()
        {
            int age = 30; // 지역변수 수정
            Console.WriteLine("func() salary : {0}, age : {1}", salary, age);
            salary += 1000000; // 전역변수 수정

        }
        static void Main(string[] args)
        {
            int age = 27;

            Console.WriteLine("Main() salary : {0}, age : {1}", salary, age);
            funcA();
            Console.WriteLine("Main() salary : {0}, age : {1}", salary, age);

            char[] str = new char[3] { 'A', 'B', 'C' }; // 생성과 동시에 초기화 가능
            // heap에 5byte 할당
            //str[0] = 'A';
            //str[1] = 'B';
            //str[2] = 'C';
            Console.WriteLine(str[0]);
            Console.WriteLine(str);

            string str2 = "kingdom";
            Console.WriteLine(str2[0]);
            Console.WriteLine(str2);

            str2 = "hello world"; // ok : str2은 주소로 저장 중
            //str2[0] = 'K'; // error : 문자열이 상수로 저장되어 있기 때문
            Console.WriteLine(str2[0]);
            Console.WriteLine(str2);

            // C#은 메모리 할당 관리가 철저하지 않음
            // 따라서 string 타입으로 문자열 자료형 사용
        }
    }
}

/* 출력 결과
Main() salary : 3500000, age : 27
func() salary : 3500000, age : 30
Main() salary : 4500000, age : 27
A
ABC
k
kingdom
h
hello world
 */

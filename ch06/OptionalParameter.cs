using System;

namespace ch06
{
    class OptionalParameter
    {
        static void PrintProfile(string name = "", string phone = "", int salary = 0)
        {
            Console.WriteLine("성명 : {0}, 전화번호 : {1}, 월급 : {2}", name, phone, salary);
        }
        static void Main(string[] args)
        {
            PrintProfile();
            PrintProfile("홍길동");
            PrintProfile("홍길동", "010-001-1234");
            PrintProfile("홍길동", "010-001-1234", 3400000);

            PrintProfile(salary:3700000, phone:"010-002-1234", name:"이묭룡"); // 명명된 인자전달
        }
    }
}

using System;

namespace ch01
{
    class Test1
    {
        public static void Main()
        {
            Console.WriteLine();
            Console.Write("성명 ? ");
            string name = Console.ReadLine();

            string tmp;

            Console.Write("출생년도 ? ");
            tmp = Console.ReadLine();
            int age = DateTime.Now.Year - int.Parse(tmp);

            Console.Write("월급 ? ");
            long salary = long.Parse(Console.ReadLine());


            Console.WriteLine("당신의 이름은 {0}입니다", name);
            Console.WriteLine("당신의 나이는 {0}입니다", age);
            Console.WriteLine("당신의 연봉은 {0:C}입니다", salary*12);
        }
    }
}

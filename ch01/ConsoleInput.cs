using System;

namespace ch01
{
    class ConsoleInput
    {
        public static void Main()
        {
            Console.Write("이름 ? "); // 줄바꿈없이 출력
            string name = Console.ReadLine(); // 줄단위로 문자열 입력

            Console.WriteLine("이름은 {0} 입니다.", name);


            Console.Write("당신의 성은 ? ");
            char name2 = (char)Console.Read(); // 한글자만 입력

            Console.WriteLine("당신의 성은 {0} 입니다.", name2);
            Console.ReadLine(); // 버퍼에 남아있는 글자 삭제

            Console.Write("나이 ? ");
            string tmp = Console.ReadLine(); // 입력으로 들어온 값은 무조건 문자열

            int age = Int32.Parse(tmp); // 방법 1
            //int age = int.Parse(tmp); // 방법 2
            //int age = Convert.ToInt32(tmp); // 방법 3
            Console.WriteLine("당신의 나이는 {0} 입니다.", age);
            Console.WriteLine();

            Console.WriteLine(DateTime.Now); // 2022-03-31 오후 2:32:39
            Console.WriteLine(DateTime.Now.Year); // 2022
            Console.WriteLine(DateTime.Now.Month); // 3
            Console.WriteLine(DateTime.Now.Day); // 31
            Console.WriteLine(DateTime.Now.Hour); // 14
            Console.WriteLine(DateTime.Now.Minute); // 35
            Console.WriteLine(DateTime.Now.Second); // 52

            Console.Write("생년월일 ? ");
            string tmp2 = Console.ReadLine(); // 날짜를 바로 받을 수 없음
            DateTime birth = DateTime.Parse(tmp2);
            DateTime birth2 = DateTime.Parse("1997-7-20");

            Console.WriteLine("생일은 {0} 입니다. ", birth); // 생일은 1997-07-24 오전 12:00:00 입니다.
            Console.WriteLine("생일은 {0} 입니다. ", birth2);

            Console.WriteLine("생일은 {0} 입니다. ", birth.ToShortDateString()); // 생일은 1997-07-24 입니다.
            Console.WriteLine("생일은 {0} 입니다. ", birth.Year); // 생일은 1997 입니다.

        }
    }
}

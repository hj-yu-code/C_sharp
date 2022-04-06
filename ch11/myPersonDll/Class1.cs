using System;

namespace myPersonDll
{
    // default : internal
    // 현재는 public으로 설정
    public class Person
    {
        public void showDate()
        {
            Console.WriteLine("현재날짜 : {0} ", DateTime.Now);
        }
    }
}

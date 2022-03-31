using System;

namespace ch01 // namespace는 생략 가능
{
    class class1
    {
        // static void Main() // 안에 내용 없어도 가능
        // static : 객체 생성 관계없이 호출
        // public static void Main(string[] args) // public 넣어도 가능
        static void Main(string[] args) // main은 class 안에서 호출 필수
        {
            Console.WriteLine("class1 Main() 실행");
            Console.WriteLine("Hello World!");
            
        }
    }
    class class2
    {
         static void Main(string[] args)
        {
            Console.WriteLine("class2 Main() 실행");
            Console.WriteLine("Hello World!");
            
        }
    }
    // '프로젝트-속성-시작개체'로 실행할 Main method 설정 가능
}

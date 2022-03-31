using System;
using GreetingWorld;

namespace HelloWorld
{
    partial class Program2
        // partial : 소스 파일이 달라도 같은 namespace의 같은 class에 있다면 연결 가능한 키워드
    {
        public static void Main()
        {
            Console.WriteLine("namespace, class, method 구분");

            GoodMorning(); // 같은 class의 매서드
            Program3.GoodBye(); // 다른 class의 매서드

            Greeting.GreetingShow1(); // 같은 namespace의 다른 class의 매서드

            GoodNight(); // 다른 소스 파일 (partial 키워드 사용)

            GreetingWorld.Greeting2.GreetingShow2(); // 다른 namespace의 다른 class의 매서드
            Greeting2.GreetingShow2(); // using 문으로 생략 가능
        }
        public static void GoodMorning()
        {
            Console.WriteLine("안녕하세요~");
        }
    }

    class Program3
    {
        public static void GoodBye()
        {
            Console.WriteLine("안녕히 가세요~");

        }
    }
}

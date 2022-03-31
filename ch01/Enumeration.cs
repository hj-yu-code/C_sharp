using System;

namespace ch01
{
    // type은 method(Main) 안에 들어갈 수 없음
    // type은 type(class)을 포함할 수 있음(단 지역type)

    enum Color 
    {
        Red,
        Green,
        Blue
    }

    enum Color2
    {
        Red=100,
        Green,
        Blue
    }

    class ConsoleApp
    {
        public static void Main()
        {
            const float PI = 3.14159F;
            Console.WriteLine("PI : {0}", PI);
            //PI = 1.5F; // 상수 변경 불가

            Color color1 = Color.Red;
            Console.WriteLine("color1 : {0}", color1); // color1 : Red
            Console.WriteLine("color1 : {0}", (int)color1); // color1 : 0

            //Color color2 = Color.Yellow; // 범위내에 없는 건 컴파일 오류
            Color color2 = Color.Green;
            Color color3 = (Color)2; // Color 타입으로 변경하면 가능
            Console.WriteLine("color2 : {0}", color2); // color1 : Green
            Console.WriteLine("color3 : {0}", color3); // color1 : Blue

            Color2 color4 = Color2.Green; // 값을 대입하면 그 상태에서 1씩 증가
            Console.WriteLine("color4 : {0}", (int)color4); // color1 : 101

        }
    }
}

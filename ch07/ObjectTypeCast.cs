using System;

namespace ch07
{
    class Token
    {
        public void Name()
        {
            Console.WriteLine("Token.");
        }
    }
    class CommandToken : Token
    {
        public void Name()
        {
            //base.Name(); // 기반 클래스 매소드는 내부에서 호출 가능
            Console.WriteLine("CommandToken.");
        }

    }
    class OnLineCommandToken : CommandToken
    {
        public void Name() // method override (매서드 재정의)
        {
            Console.WriteLine("OnLineCommandToken.");
        }
    }
    class ObjectTypeCast
    {
        static void Main(string[] args)
        {
            Token t1 = new Token();
            t1.Name(); // Token.

            CommandToken c1 = new CommandToken();
            c1.Name(); // CommandToken.

            // 파생클래스 객체가 생성되면 기반 클래스 오버라이드 된 매서드는 가려짐
            OnLineCommandToken oc1 = new OnLineCommandToken();
            oc1.Name(); // OnLineCommandToken.
            Console.WriteLine();

            Token t2, t3;
            t2 = new CommandToken(); // UpCast (o)
            t3 = new OnLineCommandToken();

            // 파생클래스 객체가 기반 클래스 객체 변수에 대입되면 기반 클래스 매서드가 호출됨
            t2.Name(); // Token.
            t3.Name(); // Token.

            //CommandToken c2 = new Token(); // DownCast (x)

            // 객체가 해당 형식에 해당하는지를 검사하여 그 결과를 bool 값으로 반환
            if (t2 is CommandToken) // 형변환 가능: true, 형변환 불가: false
            {
                c1 = (CommandToken)t2; // 명시적 형변환된 주소를 새로 받음
                c1.Name(); // CommandToken.
            }

            // 형변화를 진행하고, 실패하면 null 값을 반환
            OnLineCommandToken oc2 = t3 as OnLineCommandToken;
            if (oc2 != null)
                oc2.Name(); // OnLineCommandToken.

        }
    }
}

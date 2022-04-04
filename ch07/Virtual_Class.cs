using System;

namespace ch07
{
    class Token
    {
        public virtual void Name() // 가상함수
        {
            Console.WriteLine("Token.");
        }
    }
    class CommandToken : Token
    {
        public override void Name()
        {
            Console.WriteLine("CommandToken.");
        }
    }
    class OnLineCommandToken : CommandToken
    {
        public new void Name()
        {
            Console.WriteLine("OnLineCommandToken.");
        }
    }


    class Virtual_Class
    {
        static void Main(string[] args)
        {
            Token t1 = new Token();
            Token t2 = new CommandToken();
            Token t3 = new OnLineCommandToken();

            t1.Name();
            t2.Name();
            t3.Name();
        }
    }
}

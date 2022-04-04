using System;

namespace ch07
{
    class Token
    {
        protected string name;
        public Token()
        {
            name = "Unknown";
            Console.WriteLine("Token : " + name);
        }
        public Token(string _name)
        {
            name = _name;
            Console.WriteLine("Token(string _name) : " + name);
        }
    }
    class CommandToken : Token
    {
        public CommandToken(string _name) : base(_name) // 기반 클래스의 생성자 호출
        {
            Console.WriteLine("CommandToken(string _name) : " + name);

        }
    }

    class InheritanceConstructor
    {
        static void Main(string[] args)
        {
            // 파생클래스를 호출 할때 기반 클래스 생성자를 먼저 호출
            CommandToken c1 = new CommandToken("길동이");
        }
    }
}

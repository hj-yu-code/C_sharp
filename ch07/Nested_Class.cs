using System;

namespace ch07
{
    class firstClass
    {
        private string name;
        public firstClass()
        {
            name = "noName";
        }
        public void showData()
        {
            Console.WriteLine("name: {0}", name);
        }
        public void reName(string _name)
        {
            secondClass rName = new secondClass();
            rName.setName(ref name, _name);
        }
        class secondClass // class 중첩
        {
            public void setName(ref string _refname, string _name)
            {
                _refname = _name; // 중첩된 클래스 매서드는 상위클래스의 private 맴버에 바로 접근 가능
            }
        }
    }
    class Nested_Class
    {
        static void Main(string[] args)
        {
            firstClass my = new firstClass();
            my.showData();

            my.reName("홍길동");
            my.showData();
        }
    }
}

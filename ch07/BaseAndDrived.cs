using System;

namespace ch07
{
    class Base
    {
        protected string name;
        public void BaseMethod()
        {
            name = "Base";
            Console.WriteLine("BaseMethod() : {0}", this.name);
        }
    }
    class Derived : Base // 상속
    {
        public void DervedMethod()
        {
            name = "Derived";
            Console.WriteLine("DervedMethod() : {0}", this.name);
        }
    }
    class BaseAndDrived
    {
        static void Main(string[] args)
        {
            Base b1 = new Base();
            b1.BaseMethod();

            Derived d1 = new Derived();
            d1.BaseMethod();
            d1.DervedMethod();

        }
    }
}

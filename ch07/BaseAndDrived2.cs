using System;

namespace ch07
{
    class Base
    {
        protected string name;
        protected int salary;

        public Base()
        {
            name = "Base";
            salary = 0;
        }
        public void BaseMethod()
        {
            Console.WriteLine("BaseMethod() : {0}, {1}", name, salary);
        }
    }
    class Derived : Base
    {
        protected string name;
        protected string telno;

        public Derived()
        {
            name = "Derived";
            telno = "010-001-1234";
            salary = 350000;

        }
        public void DerivedMethod()
        {
            //Console.WriteLine("DerivedMethod() : {0}, {1}, {2}, {3}", base.name, this.name, this.telno, base.salary); // 아래와 같음
            Console.WriteLine("DerivedMethod() : {0}, {1}, {2}, {3}", base.name, name, telno, salary);
        }
    }
    class BaseAndDrived2
    {
        static void Main(string[] args)
        {
            Base b1 = new Base();
            b1.BaseMethod();
            Derived d1 = new Derived();
            d1.DerivedMethod();
            d1.BaseMethod();
        }

    }
}

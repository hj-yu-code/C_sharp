using System;

namespace ch07
{
    struct Employee
    {
        private string name;
        private int salary;
        private DateTime birth;

        //public Employee() // 디폴트 생성자는 명시적 생성불가
        //{
        //    Console.WriteLine("Employee() called.");
        //}
        public Employee(string _name, int _sal, DateTime _birth)
        {
            Console.WriteLine("Employee() called.");
            name = _name;
            salary = _sal;
            birth = _birth;
        }
        public Employee(string _name, int _sal) // 생성자는 부분 초기화를 허용하지 않음
        {
            Console.WriteLine("Employee() called.");
            name = _name;
            salary = _sal;
            birth = DateTime.Parse("2022-05-01"); // 클래스와 다른점!
        }

        public void showData()
        {
            Console.WriteLine("{0}, {1}, {2}", name, salary, birth);
        }

    }
    class ConsoleApp
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.showData();
            
            Employee e2 = new Employee("길동이", 2700000, DateTime.Parse("2022-04-01"));
            e2.showData();

            Employee e3 = new Employee("길동22", 2700000);
            e3.showData();

            //Employee e4; // 할당되지 않은 구조체 변수
            //e4.showData();
        }

    }
}

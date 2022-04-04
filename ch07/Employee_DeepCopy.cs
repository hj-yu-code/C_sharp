using System;

namespace ch07
{
    class Employee
    {
        private string name;
        private int salary;
        private string comAddr;

        public Employee()
        {
        }
        public Employee(string name, int salary, string comAddr)
        {
            this.name = name;
            this.salary = salary;
            this.comAddr = comAddr;
        }

        public void showData()
        {
            Console.WriteLine("{0}, {1}, {2}", name, salary, comAddr);
        }

        public void addSalary(int _sudang)
        {
            salary += _sudang;
        }
        public Employee DeepCopy() // this : e1
        {
            Employee newCopy = new Employee();
            newCopy.name = this.name;
            newCopy.salary = this.salary;
            newCopy.comAddr = this.comAddr;
            return newCopy;
        }
    }
    class Employee_DeepCopy
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("성춘향", 3700000, "서울시 강남구");
            e1.showData();

            Employee tmp;
            tmp = e1; // 참조 복사
            tmp.addSalary(200000);

            e1.showData();
            tmp.showData();

            Employee e2 = new Employee("길동이", 2000000, "서울시 동대문구");
            Employee tmp2 = e2.DeepCopy();
            tmp2.showData();
            tmp2.addSalary(500000);

            e2.showData();
            tmp2.showData();
        }
    }
}

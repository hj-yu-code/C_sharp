using System;
namespace ch07
{
    class Car
    {
        private readonly int count = 5;
        private const int speed = 10;

        public Car()
        {

        }
        public Car(int _n)
        {
            count = _n; // 생성자에서 readonly필드 값 
            //speed = _n; // 상수는 절대 할당 불가
        }
        public void showData()
        {
            Console.WriteLine("count: {0} ", count);
            Console.WriteLine("speed: {0} ", speed);
        }
    }
    class Class1_ReadOnly
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            c1.showData();

            Car c2 = new Car(20);
            c2.showData();
        }
    }
}

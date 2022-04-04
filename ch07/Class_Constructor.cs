using System;

namespace ch07
{
    class Date
    {
        public int yy;
        public int mm;
        public int dd;

        public Date() : this(2022, 1, 1) // 이웃 생성자 호출
            // this : 생성자 중에서 이와 같은 형태로 인자를 받는 생성자를 호출
        {
            Console.WriteLine("Date() called.");
            //yy = DateTime.Now.Year;
            //mm = DateTime.Now.Month;
            //dd = DateTime.Now.Day;
            

        }
        public Date(int yy, int mm, int dd)
        {
            this.yy = yy;
            this.mm = mm;
            this.dd = dd;
        }
            public void showDate()
        {
            Console.WriteLine("{0}년 {1}월 {2}일 ", yy, mm, dd);
        }
    }
    class Class_Constructor
    {
        static void Main(string[] args)
        {
            Date d1 = new Date(); // default 생성자 호출

            d1.showDate();

            Date d2 = new Date(2022, 4, 5);
            d2.showDate();

            Date d3 = new Date();
            d3.showDate();
        }
    }
}

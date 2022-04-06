using System;

namespace ConstraintsOnTypeParameters
{
    class StructArray<T> where T : struct  //값형식만 저장(stack에 저장)
        // where : 제약을 결어줌
    {
        //객체 생성을 하면서 생성자에 넘겨준 3에 의해 
        //a 객체안의 배열 타입의 속성인 Array 자동속성의 배열 크기를 결정 한다.
        public T[] Array { get; set; }
        public StructArray(int size)
        {
            Array = new T[size];
        }
    }

    class RefArray<T> where T : class   //참조형식
    {
        public T[] Array { get; set; }
        public RefArray(int size)
        {
            Array = new T[size];
        }
    }

    class myNum
    {
        public int num { get; set; }

        public void Show()
        {
            Console.WriteLine("myNum: {0} ", num);
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            StructArray<int> a = new StructArray<int>(3);
            a.Array[0] = 100;
            a.Array[1] = 200;
            a.Array[2] = 300;

            for (int i = 0; i < a.Array.Length; i++)
                Console.Write("{0}, ", a.Array[i]);
            Console.WriteLine("\n");

            RefArray<myNum> a2 = new RefArray<myNum>(3);
            // clas type 객체(myNum)가 3개 생성
            a2.Array[0] = new myNum();
            a2.Array[1] = new myNum();
            a2.Array[2] = new myNum();

            a2.Array[0].num = 10;
            a2.Array[1].num = 11;
            a2.Array[2].num = 12;

            for (int i = 0; i < a2.Array.Length; i++)
                a2.Array[i].Show();
                //Console.Write("{0}, ", a2.Array[i].num);
                // 둘다 가능
            Console.WriteLine("\n");
        }
    }
}
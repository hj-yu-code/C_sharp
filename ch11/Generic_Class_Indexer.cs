using System;

namespace ch11
{
    class MyList<T>
    {
        private T[] array;
        public MyList()
        {
            array = new T[3];
        }
        public T this[int index] // 해당 type 반환
        {
            get { return array[index]; }
            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<T>(ref array, index + 1);
                    Console.WriteLine("array.Length : {0}", array.Length);
                }
                array[index] = value;
            }
        }
        public int length()
        {
            return array.Length;
        }
    }
    class Generic_Class_Indexer
    {
        static void Main(string[] args)
        {
            MyList<string> strList = new MyList<string>();
            strList[0] = "하나";
            strList[1] = "둘";
            strList[2] = "three";

            for(int i = 0; i<strList.length(); i++)
            {
                Console.WriteLine(strList[i]); // string type 반환
            }
            Console.WriteLine();

            MyList<int> intList = new MyList<int>();
            intList[0] = 100;
            intList[1] = 200;
            intList[2] = 300;
            intList[3] = 400; // 배열 크기 늘려야함
            // heap이므로 늘릴 수 있음
            // set에서 resize로 변경
            intList[4] = 500;

            for (int i = 0; i < intList.length(); i++)
            {
                Console.WriteLine(intList[i]); // int type 반환
            }
            Console.WriteLine();
        }
    }
}

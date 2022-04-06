using System;
using System.Collections;

namespace ch11
{
    class HashTableProgram
    {
        public static void DataShow(Hashtable HList)
        {
            // IDictionaryEnumerator : 인터페이스에서 제공해주는 집합 타입
            IDictionaryEnumerator myEnum = HList.GetEnumerator(); // 컬렉션에서 반복하는 반복자를 반환

            while (myEnum.MoveNext())
                Console.WriteLine("{0}, {1}", myEnum.Key, myEnum.Value);
            
        }
        static void Main(string[] args)
        {
            Hashtable nameHT = new Hashtable();

            nameHT.Add("홍길동", 3500000); // key, value 입력
            nameHT.Add("이몽룡", 2700000);
            nameHT.Add("성춘향", 5700000);
            nameHT.Add("진달래", 2900000);

            DataShow(nameHT);
            Console.WriteLine();

            bool ret = nameHT.ContainsKey("이몽룡tt");
            Console.WriteLine("이몽룡 존재여부 : {0} ", ret);

            nameHT.Remove("이몽룡");
            DataShow(nameHT);
            Console.WriteLine();

            // Hashtable은 열거자, 크기 필요
            // key 값만 보기
            ICollection myKey = nameHT.Keys;
            foreach (object item in myKey)
                Console.Write("{0}, ", item);
            Console.WriteLine();

            // value 값만 보기
            ICollection myValue = nameHT.Values;
            foreach (object item in myValue)
                Console.Write("{0}, ", item);
            Console.WriteLine();
        }
    }
}

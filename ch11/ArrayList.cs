using System;
using System.Collections; // ArrayList에서 필요

namespace ch11
{
    class ArrayList2 // 내장 함수와 충돌
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList(); // c++ STL과 유사
            list.Add(100);
            list.Add(3.14);
            list.Add('A');
            list.Add("hello");

            Console.WriteLine(list[0]);
            Console.WriteLine(list[1]);
            Console.WriteLine();

            foreach (object tmp in list)
            // type이 정해지지 않아서 object로 받기
                Console.Write("{0}, ", tmp.ToString());
            Console.WriteLine();

            list.Remove(3.14); // 해당 값 삭제
            list.RemoveAt(1); // index 삭제
            foreach (object tmp in list)
                Console.Write("{0}, ", tmp.ToString());
            Console.WriteLine();

            for(int i = 0;i<list.Count; i++)
                Console.Write("{0}, ", list[i]);
            Console.WriteLine();
        }
    }
}

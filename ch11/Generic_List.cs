using System;
using System.Collections.Generic;

namespace ch11
{
    class Generic_List
    {
        static void Main(string[] args)
        {
            List<string> list1 = new List<string>();
            list1.Add("한송이");
            list1.Add("두송이");
            list1.Add("세송이");
            list1.Add("네송이");

            foreach (string item in list1)
                Console.Write("{0}, ", item);
            Console.WriteLine();

            list1.RemoveAt(1);
            foreach (string item in list1)
                Console.Write("{0}, ", item);
            Console.WriteLine();

            List<int> list2 = new List<int>();
            list2.Add(100);
            list2.Add(200);
            list2.Add(300);
            list2.Add(400);
            list2.Add(500);
            list2.Add(6000);
            list2.Add(60);
            list2.Add(1);
            foreach (int item in list2)
                Console.Write("{0}, ", item);
            Console.WriteLine();

            int N = 300;
            if (list2.Contains(N))
            {
                Console.WriteLine("{0} 이 리스트에 있습니다.", N);
            }

            list2.Sort();
            foreach (int item in list2)
                Console.Write("{0}, ", item);
            Console.WriteLine();

        }
    }
}

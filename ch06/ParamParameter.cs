using System;

namespace ch06
{
    class ParamParameter
    {
        static int AddList(params int[] arr)
        //params : 가변길이 매개변수
        {
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int ret;
            ret = AddList(array1);
            Console.WriteLine("ret : {0}", ret);

            ret = AddList(array2);
            Console.WriteLine("ret : {0}", ret);

            ret = AddList(10, 20, 30, 40, 50, 60, 70);
            Console.WriteLine("ret : {0}", ret);

            int a = 4;
            int b = 3;
            ret = AddList(a, b);
            Console.WriteLine("ret : {0}", ret);
        }
    }
}

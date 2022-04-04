using System;

namespace ch10
{
    class Test4
    {
        static int Input(string[] _name, int[] _salary, string[] _comAddr)
        {
            int i;
            for(i = 0; i<_name.Length; i++)
            {
                Console.Write("성명 ? (입력종료: end");
                _name[i] = Console.ReadLine();
                if (string.Compare(_name[i], "end", true) == 0)
                    break;
                Console.Write("월급 ? ");
                _salary[i] = int.Parse(Console.ReadLine());

                Console.Write("주소 ? ");
                _comAddr[i] = Console.ReadLine();

            }
            return i;
        }

        static void Main()
        {
            string[] name = new string[5];
            int[] salary = new int[5];
            string[] comAddr = new string[5];
            int size, salTot = 0;

            size = Input(name, salary, comAddr);

            Console.WriteLine();
            for(int i = 0; i < size; i++)
            {
                Console.WriteLine("{0}, {1:N0}, {2} ", name[i], salary[i], comAddr[i]);
                salTot += salary[i];
            }
            if (size != 0)
                Console.WriteLine("월급평균 : {0} ", salTot / size);

        }
    }
}

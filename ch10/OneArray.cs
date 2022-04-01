using System;
namespace ch10
{
    class OneArray
    {
        static void scoreInput(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} 성적 ? ", i+1);
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
        static void scoreOutput(int[] arr)
        {
            Console.WriteLine("\n학생점수 출력");
            for(int i = 0; i < arr.Length; i++)
                Console.Write("{0}, ", arr[i]);
            Console.WriteLine();
        }
        static void scoreCalc(int[] arr)
        {
            int sum = arr[0], min = arr[0], max = arr[0];
            double avg;

            for (int i = 1; i < arr.Length; i++)
            {
                sum += arr[i];
                if (arr[i] > max)
                    max = arr[i];
                if (arr[i] < min)
                    min = arr[i];
            }
            avg = sum / arr.Length;
            Console.WriteLine("함계 : {0}, 평균 : {1}, 최고 점수 : {2}, 최저 점수 : {3}", sum, avg, max, min);
        }
        static void Main(string[] args)
        {
            int[] score = new int[5];

            scoreInput(score); // array는 주소값이므로 ref 필요 없음
            scoreOutput(score);
            scoreCalc(score);
        }
    }
}

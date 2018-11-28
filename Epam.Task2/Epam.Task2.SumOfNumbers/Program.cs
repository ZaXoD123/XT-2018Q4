using System;

namespace Epam.Task2.SumOfNumbers
{
    public class Program
    {
        public static int FuncCur(int i, int maxValue)
        {
            int first = 0;
            int second = 0;
            int firstPlusSecond = 0;
            if (i * 3 < maxValue)
            {
                first = i * 3;
            }

            if (i * 5 < maxValue)
            {
                second = i * 5;
            }

            if (i * 3 * 5 < maxValue)
            {
                firstPlusSecond = i * 3 * 5;
            }

            return first + second - firstPlusSecond;
        }

        public static void SumOfNumbersShow(int n = 1000)
        {
            int sum = 0;
            for (int i = 1, tmp; (tmp = FuncCur(i, n)) != 0; i++) 
            {
                sum += tmp;
            }

            Console.WriteLine($"Sum: {sum}");
        }

        public static void Main(string[] args)
        {
            SumOfNumbersShow();
        }
    }
}
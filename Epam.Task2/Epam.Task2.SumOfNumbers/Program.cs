using System;

namespace Epam.Task2.SumOfNumbers
{
    class Program
    {
        static int FuncCur(int i, int maxValue) 
            => ((i * 3 < maxValue) ? i * 3 : 0) + ((i * 5 < maxValue) ? i * 5 : 0) - ((i * 5 * 3 < maxValue) ? i * 5 * 3 : 0);
        static void SumOfNumbersShow(int n=1000)
        {
            int sum = 0;
            for (int i = 1, tmp; (tmp = FuncCur(i,n))!=0; i++)
            {
                sum += tmp;
            }
            Console.WriteLine($"Sum: {sum}");
        }
        static void Main(string[] args)
        {
            SumOfNumbersShow();
        }
    }
}
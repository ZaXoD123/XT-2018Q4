﻿using System;

namespace Epam.Task5.NumberArraySum
{
    internal static class Sum
    {
        private static T GetSum<T>(this Array array, Func<T, T, T> sumFunc)
        {
            var temp = Activator.CreateInstance<T>();
            foreach (var item in array)
            {
                temp = sumFunc(temp, (T)item);
            }
            return temp;
        }

        public static int GetSum(this int[] array) => array.GetSum<int>((x, y) => x + y);
        
        public static double GetSum(this double[] array) => array.GetSum<double>((x, y) => x + y);
        
        public static decimal GetSum(this decimal[] array) => array.GetSum<decimal>((x, y) => x + y);
    }

    internal static class Program
    {
        private static void Main(string[] args)
        {
            var a = new[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(a.GetSum());
        }
    }
}
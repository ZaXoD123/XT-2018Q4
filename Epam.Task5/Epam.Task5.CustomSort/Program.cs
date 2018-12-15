using System;

namespace Epam.Task5.CustomSort
{
    public static class Program
    {
        public static void Sort<T>(this T[] array, Func<T, T, int> compare, int start, int stop)
        {
            
            var left = start;
            var right = stop;
            var value = array[stop - 1];

            while (left <= right)
            {
                while (compare(array[left], value) < 0)
                {
                    left++;
                }

                while (compare(array[right], value) > 0)
                {
                    right--;
                }

                if (left <= right)
                {
                    var temp = array[left];
                    array[left] = array[right];
                    array[right] = temp;
                    left++;
                    right--;
                }
            }

            if (right > start)
            {
                Sort(array, compare, start, right);
            }

            if (stop > left)
            {
                Sort(array, compare, left, stop);
            }
        }

        private static void Main(string[] args)
        {
            var array = new[] { 1, 9, 8, 2, 5 };
            Func<int, int, int> compare = (z, x) => z == x ? 0 : (z - x) / Math.Abs(z - x);
            Sort(array, compare, 0, array.Length - 1);
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            compare = (z, x) => z == x ? 0 : -1 * (z - x) / Math.Abs(z - x);

            Sort(array, compare, 0, array.Length - 1);
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
        }
    }
}
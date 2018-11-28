using System;

namespace Epam.Task2.ArrayProcessing
{
    public class Program 
    {
        public static void Sort<T>(T[] array, int start, int stop) where T : IComparable
        {
            T temp;
            var left = start;
            var right = stop;
            var value = array[stop - 1];
            
            while (left <= right)
            {
                while (array[left].CompareTo(value) < 0)
                {
                    left++;
                }

                while (array[right].CompareTo(value) > 0)
                {
                    right--;
                }

                if (left <= right)
                {
                    temp = array[left];
                    array[left] = array[right];
                    array[right] = temp;
                    left++;
                    right--;
                }
            }

            if (right > start)
            {
                Sort(array, start, right);
            }

            if (stop > left)
            {
                Sort(array, left, stop);
            }
        }

        public static (T, T) MaximumAndMinimumFind<T>(T[] array) where T : IComparable 
        {
            T maximum = array[0];
            T minimum = array[0];
            foreach (var i in array)
            {
                maximum = i.CompareTo(maximum) > 0 ? i : maximum;
                minimum = i.CompareTo(minimum) < 0 ? i : minimum;
            }

            return (minimum, maximum);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter massive length:");
            int[] array = new int[int.Parse(Console.ReadLine())];
            var generator = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = generator.Next(100);
            }

            Console.WriteLine("Maximum is {0}{1}Minimum is {2}", MaximumAndMinimumFind(array).Item1, Environment.NewLine, MaximumAndMinimumFind(array).Item2);
            Sort(array, 0, array.Length - 1);
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
        }
    }
}

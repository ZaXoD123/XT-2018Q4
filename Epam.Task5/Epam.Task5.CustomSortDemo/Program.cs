using System;
using SortD = Epam.Task5.CustomSort.Program;

namespace Epam.Task5.CustomSortDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var array = new[] { "three", "two", "o", "a", "b" };
            Func<string, string, int> compare = (x, y) =>
            {
                if (x.Length != y.Length)
                {
                    return (x.Length - y.Length) / Math.Abs(x.Length - y.Length);
                }
                return x.CompareTo(y);
            };

            SortD.Sort(array, compare, 0, array.Length - 1);
            foreach (var item in array) Console.WriteLine(item);
        }
    }
}
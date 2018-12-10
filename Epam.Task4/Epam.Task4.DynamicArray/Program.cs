using System;
using System.Collections.Generic;

namespace Epam.Task4.DynamicArray
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var a = new DynamicArray<int>(new List<int> { 1, 2, 3 });
            a.AddRange(new List<int> { 4, 5, 6, 7 });
            a.Add(8);
            foreach (var item in a)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine($"{Environment.NewLine}Length: {a.Length}{Environment.NewLine}Capacity: {a.Capacity}");

            a.Insert(1000, 3);
            a.Remove(0);
            foreach (var item in a)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
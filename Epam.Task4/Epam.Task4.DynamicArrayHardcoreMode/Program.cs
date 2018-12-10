using System;
using System.Collections.Generic;

namespace Epam.Task4.DynamicArrayHardcoreMode
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var testArray1 = new DynamicArrayHardcoreMode<int>(new List<int> { 1, 2, 3 });
            testArray1.AddRange(new List<int> { 4, 5, 6, 7 });
            testArray1.Add(8);
            testArray1 = testArray1.Clone() as DynamicArrayHardcoreMode<int>;

            foreach (var item in testArray1)
            {
                Console.Write($"{item} ");
            }

            for (var i = -1; i >= -testArray1.Length; i--)
            {
                Console.WriteLine($"{i}) {testArray1[i]}");
            }

            Console.WriteLine($"{Environment.NewLine}Get ready and press any key");
            Console.ReadKey();

            var testArray2 = new CycledDynamicArray<int>(new List<int> { 1, 2, 3, 4, 5 });
            foreach (var item in testArray2)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
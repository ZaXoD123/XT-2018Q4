using System;
using System.Text.RegularExpressions;

namespace Epam.Task8.TimeCounter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var result = Regex.Matches(Console.ReadLine(), @"(2[0-3]|[01]?[0-9]):[0-5][0-9]");
            Console.WriteLine($"Time in the text is presented {result.Count} times");
        }
    }
}
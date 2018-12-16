using System;
using System.Text.RegularExpressions;

namespace Epam.Task5.ToIntOrNotToInt
{
    internal class Program
    {
        private static bool IsInt(string str)
        {
            var template = new Regex(@"(\d*\.*\d+E[+,-]\d+)|(\d*\.*\d+)");
            return template.IsMatch(str) & (template.Replace(str, string.Empty) == string.Empty);
        }

        private static void Main(string[] args)
        {
            Console.WriteLine(IsInt(Console.ReadLine()));
        }
    }
}
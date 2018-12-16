using System;
using System.Text.RegularExpressions;

namespace Epam.Task5.ToIntOrNotToInt
{
    internal class Program
    {
        private static bool IsInt(string str)
        {
            var template = new Regex(@"(\d*\.*\d+E[+,-]\d+)|(\d*\.*\d+)");
            return template.IsMatch(str) & template.Matches(str).Count == 1 & (template.Replace(str, string.Empty) == string.Empty);
        }

        private static void Main(string[] args)
        {
            Console.WriteLine($"12.12E+20: {IsInt("12.12E+20")}");
            Console.WriteLine($"12.E+20: {IsInt("12.E+20")}");
            Console.WriteLine($"12.12E+: {IsInt("12.12E+")}");
            Console.WriteLine($"1234E+1: {IsInt("1234E+1")}");
            Console.WriteLine($"1234: {IsInt("1234")}");
            Console.WriteLine($"123.123.123: {IsInt("123.123.123")}");
        }
    }
}
using System;
using System.Text.RegularExpressions;

namespace Epam.Task8.EmailFinder
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter text with emails:");
            var result = Regex.Matches(Console.ReadLine(), @"[a-zA-Z0-9]([a-zA-Z\.0-9_-]*[a-zA-Z0-9])?@([a-zA-Z0-9-]+\.)+[a-zA-Z]{2,6}");
            Console.WriteLine("Emails:");
            foreach (var item in result)
            {
                Console.WriteLine($"\"{item}\"");
            }
        }
    }
}
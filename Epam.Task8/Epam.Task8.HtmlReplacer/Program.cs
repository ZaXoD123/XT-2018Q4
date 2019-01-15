using System;
using System.Text.RegularExpressions;

namespace Epam.Task8.HtmlReplacer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter HTML here:");
            var result = Regex.Replace(Console.ReadLine(), "<[/]?[^<>]+>", "_");
            Console.WriteLine("Result:" + result);
        }
    }
}
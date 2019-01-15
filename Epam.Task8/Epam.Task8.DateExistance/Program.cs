using System;
using System.Text.RegularExpressions;

namespace Epam.Task8.DateExistance
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter text:");
            var input = Console.ReadLine();
            var result = Regex.IsMatch(input, "(3[0-1]|[0-2][0-9])-(0[0-9]|1[1,2])-[0-9]{4}");
            Console.WriteLine("the text \"{0}\"{1} contain the date", input, result ? string.Empty : " does not");
        }
    }
}
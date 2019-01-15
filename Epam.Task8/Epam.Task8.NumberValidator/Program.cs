using System;
using System.Text.RegularExpressions;

namespace Epam.Task8.NumberValidator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            var input = Console.ReadLine();
            if (Regex.Replace(input, @"-?[0-9]+(\.[0-9]+)?e[+-]?[0-9]+", string.Empty) == string.Empty)
            {
                Console.WriteLine("This number is in scientific notation.");
            }
            else if (Regex.Replace(input, @"-?[0-9]+(\.[0-9]+)?", string.Empty) == string.Empty)
            {
                Console.WriteLine("This number is in standart notation.");
            }
            else
            {
                Console.WriteLine("This is not a number");
            }
        }
    }
}
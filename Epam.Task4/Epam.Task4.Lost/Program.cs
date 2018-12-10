using System;
using System.Collections.Generic;
using System.Linq;

namespace Epam.Task4.Lost
{
    internal class Program
    {
        private static T LastMethod<T>(List<T> persons)
        {
            var current = 1;
            while (persons.Count > 1)
            {
                current = current % persons.Count;
                persons.RemoveAt(current++);
            }

            return persons[0];
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Enter count of persons: ");
            inputLabel:
            if (!int.TryParse(Console.ReadLine(), out var input) || input < 1)
            {
                Console.WriteLine($"Wrong value. Try again {input}");
                goto inputLabel;
            }

            var persons = new List<int>(Enumerable.Range(1, input));

            Console.WriteLine(LastMethod(persons));
        }
    }
}
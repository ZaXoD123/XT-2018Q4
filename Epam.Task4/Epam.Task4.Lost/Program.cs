using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task4.Lost
{
    class Program
    {
        static T LastMethod<T>(List<T> persons)
        {
            int current = 1;
            while (persons.Count > 1)
            {
                current = current % persons.Count;
                persons.RemoveAt(current++);
            }
            
            return persons[0];
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter count of persons: ");
            inputLabel:
            if (!int.TryParse(Console.ReadLine(), out var input) || input < 1)
            {
                Console.WriteLine($"Wrong value. Try again {input}");
                goto inputLabel;
            }

            List<int> persons = new List<int>(Enumerable.Range(1,input));
            
            Console.WriteLine(LastMethod(persons));
        }
    }
}

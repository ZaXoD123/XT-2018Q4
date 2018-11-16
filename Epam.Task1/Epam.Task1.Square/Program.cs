using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1.Square
{
    class Program
    {
        static void Square(int n)
        {
            var tempString = String.Concat(Enumerable.Repeat(new string('*', n) + Environment.NewLine, n / 2));
            Console.WriteLine($"{tempString}{new string('*', n / 2)} {new string('*', n / 2)}{Environment.NewLine}{tempString}"); 
        }

        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Square(n);
        }
    }
}

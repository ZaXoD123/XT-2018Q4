using System;
using System.Linq;

namespace Epam.Task1.Square
{
    class Program
    {
        static void Square(int n)
        {
            if ((n < 1) || ((n & 1) == 0)) throw new Exception("Wrong input!");
            //var tempString = String.Concat(Enumerable.Repeat(new string('*', n) + Environment.NewLine, n / 2));
            //Console.WriteLine($"{tempString}{new string('*', n / 2)} {new string('*', n / 2)}{Environment.NewLine}{tempString}"); 
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{new string('*',n/2)}{(i==(n/2+1)?' ':'*')}{new string('*', n / 2)}");
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a positive uneven integer [1+]: ");
            int.TryParse(Console.ReadLine(), out int n);
            Square(n);
        }
    }
}

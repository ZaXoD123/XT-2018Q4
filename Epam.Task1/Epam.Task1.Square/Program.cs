using System;
using System.Linq;

namespace Epam.Task1.Square
{
    public class Program
    {
        public static void Square(int n)
        {
            if ((n < 1) || ((n & 1) == 0))
            {
                throw new Exception("Wrong input!");
            }

            for (int i = 1; i <= n; i++)
            {
                string a = new string('*', n / 2);
                char b = (i == (n / 2 + 1)) ? ' ' : '*';
                string c = new string('*', n / 2);
                Console.WriteLine($"{a}{b}{c}");
            }
        }

        public static void Main(string[] args)
        {
        start:
            Console.WriteLine("Enter a positive integer [1+]: ");
            int.TryParse(Console.ReadLine(), out int n);
            Console.Clear();
            try
            {
                Square(n);
            }
            catch (Exception currentException)
            {
                Console.WriteLine($"FAIL! {currentException.Message}{Environment.NewLine}Try again:");
                goto start;
            }
        }
    }
}

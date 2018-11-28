using System;

namespace Epam.Task2.XmasTree
{
    public class Program
    {
        public static void XmasTreeShow(int n, int shift = 0)
        {
            if (n <= 0)
            {
                throw new Exception("Wrong values!");
            }

            if (n > 1)
            {
                XmasTreeShow(n - 1, shift + 1);
            }

            for (int number = 1; number <= n; number++)
            {
                for (int i = 0; i < ((n + shift - number) + (2 * number - 1)); i++)
                {
                    Console.Write((i < (n + shift - number)) ? ' ' : '*');
                }

                Console.Write(Environment.NewLine);
            }
        }

        public static void Main(string[] args)
        {
        start:
            Console.WriteLine("Enter count of lines:");
            int.TryParse(Console.ReadLine(), out int n);
            Console.Clear();
            try
            {
                XmasTreeShow(n);
            }
            catch (Exception currentException)
            {
                Console.WriteLine($"FAIL! {currentException.Message}{Environment.NewLine}Try again:");
                goto start;
            }
        }
    }
}

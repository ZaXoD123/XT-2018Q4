using System;
using System.Linq;

namespace Epam.Task2.AnotherTriangle
{
    public class Program
    {
        public static void AnotherTriangleShow(int n)
        {
            if (n <= 0)
            {
                throw new Exception("Wrong values!");
            }
            
            for (int number = 1; number <= n; number++)
            {
                for (int i = 0; i < ((n - number) + (2 * number - 1)); i++)
                {
                    Console.Write((i < (n - number)) ? ' ' : '*');
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
                AnotherTriangleShow(n);
            }
            catch (Exception currentException)
            {
                Console.WriteLine($"FAIL! {currentException.Message}{Environment.NewLine}Try again:");
                goto start;
            }
        }
    }
}

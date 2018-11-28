using System;

namespace Epam.Task1.Sequence
{
    public class Program
    {
        public static void SequenceFunction(int n)
        {
            if (n < 1)
            {
                throw new Exception("This number is wrong");
            }

            for (int i = 1; i < n; i++)
            {
                Console.Write($"{i}, ");
            }

            Console.WriteLine(n); 
        }

        public static void Main()
        {
        start:
            Console.WriteLine("Enter a positive integer [1+]: ");
            int.TryParse(Console.ReadLine(), out int n);
            Console.Clear();
            try
            {
                SequenceFunction(n);
            }
            catch (Exception currentException)
            {
                Console.WriteLine($"FAIL! {currentException.Message}{Environment.NewLine}Try again:");
                goto start;
            }
        }
    }
}

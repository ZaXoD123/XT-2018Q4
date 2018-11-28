using System;

namespace Epam.Task1.Simple
{
    public class Program
    {
        public static bool SimpleFunc(int n)
        {
            if (n < 1)
            {
                throw new Exception("This number is wrong");
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static void Main(string[] args)
        {
            Console.Write("Enter a positive integer [1+]: ");
            int.TryParse(Console.ReadLine(), out int n);
            Console.WriteLine($"Is this simple: {SimpleFunc(n)}");
        }
    }
}

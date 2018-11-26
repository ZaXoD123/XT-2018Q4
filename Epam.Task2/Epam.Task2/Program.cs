using System;

namespace Epam.Task2.Rectangle
{
    class Program
    {
        static void RectangleAreaSolve(int a, int b)
        {
            if (!((a > 0) && (b > 0))) throw new Exception("Wrong values!");
            Console.WriteLine($"Reactangle area is {a*b}");
        }
        static void Main()
        {
            start:
            Console.WriteLine("Enter length and width of rectangle:");
            int.TryParse(Console.ReadLine(), out int a);
            int.TryParse(Console.ReadLine(), out int b);
            Console.Clear();
            try
            {
                RectangleAreaSolve(a, b);
            }
            catch (Exception currentException)
            {
                Console.WriteLine($"FAIL! {currentException.Message}{Environment.NewLine}Try again:");
                goto start;
            }
        }
    }
}

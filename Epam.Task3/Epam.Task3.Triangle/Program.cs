using System;

namespace Epam.Task3.Triangle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var testTriangle1 = new Triangle(7, 5, 5);
            Console.WriteLine($"Round area is: {testTriangle1.GetTriangleArea()}");

            // Incorrect values test
            try
            {
                var testTriangle2 = new Triangle(10, 5, 5);
                Console.WriteLine(testTriangle2.GetTriangleArea());
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}

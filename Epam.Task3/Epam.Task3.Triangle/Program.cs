using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var testRound1 = new Triangle(7, 5, 5);
            Console.WriteLine($"Round area is: {testRound1.GetTriangleArea()}");

            //Incorrect values test
            try
            {
                var testRound2 = new Triangle(10, 5, 5);
                Console.WriteLine(testRound2.GetTriangleArea());
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}

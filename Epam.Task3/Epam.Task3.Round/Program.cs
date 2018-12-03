using System;

namespace Epam.Task3.Round
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var testRound1 = new Round(10, 5, 5);
            Console.WriteLine($"Round area is: {testRound1.RoundArea}");

            //Incorrect values test
            try
            {
                var testRound2 = new Round(-2, 0, 0);
                Console.WriteLine(testRound2.RoundArea);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
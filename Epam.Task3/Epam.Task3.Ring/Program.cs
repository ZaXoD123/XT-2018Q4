namespace Epam.Task3.Ring
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var testRound1 = new Ring(11, 10, 5, 5);
            Console.WriteLine($"Ring area is: {testRound1.RingArea}");

            // Incorrect values test
            try
            {
                var testRound2 = new Ring(10, 15, 5, 5);
                Console.WriteLine(testRound2.RingArea);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}

namespace Epam.Task3.Ring
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var testRing1 = new Ring(11, 10, 5, 5);
            Console.WriteLine($"Ring area is: {testRing1.RingArea}");

            // Incorrect values test
            try
            {
                var testRing2 = new Ring(10, 15, 5, 5);
                Console.WriteLine(testRing2.RingArea);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}

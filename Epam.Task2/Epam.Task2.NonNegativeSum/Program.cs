using System;
using System.Linq;

namespace Epam.Task2.NonNegativeSum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter rank of massive: ");
            var generator = new Random();
            int.TryParse(Console.ReadLine(), out int rank);
            var array = new int[rank];
            Console.WriteLine("Massive is:");
            for (int i = 0; i < rank; i++)
            {
                array[i] = generator.Next(1000) - 500;
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine(Environment.NewLine + array.Where(x => x > 0).Sum());
        }
    }
}

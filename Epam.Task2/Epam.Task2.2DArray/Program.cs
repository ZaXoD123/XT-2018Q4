using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2._2DArray
{
    public class Program
    {
        public static void Main(string[] args)
        {
        startInput:
            Console.WriteLine("Enter matrix coordinats (x,y): ");
            var generator = new Random();
            int.TryParse(Console.ReadLine(), out int x);
            int.TryParse(Console.ReadLine(), out int y);
            if ((x < 1) || (y < 1))
            {
                Console.WriteLine("Error! Wrong values!");
                goto startInput;
            }

            var array = new int[x, y];
            Console.WriteLine("Massive is:");
            for (int ix = 0; ix < x; ix++)
            {
                for (int iy = 0; iy < y; iy++)
                {
                    array[ix, iy] = generator.Next(1000) - 500;
                    Console.Write($"{array[ix, iy]} ");
                }

                Console.WriteLine();
            }

            var sum = 0;
            for (int ix = 0; ix < x; ix++)
            {
                for (int iy = 0; iy < y; iy++)
                {
                    if (((ix + iy) & 1) == 0)
                    {
                        sum += array[ix, iy];
                    }
                }
            }

            Console.WriteLine($"Sum is: {sum}");
        }
    }
}

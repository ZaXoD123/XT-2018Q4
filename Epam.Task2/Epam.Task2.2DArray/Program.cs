using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2._2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter matrix coordinats (x,y): ");
            var generator = new Random();
            int.TryParse(Console.ReadLine(), out int x);
            int.TryParse(Console.ReadLine(), out int y);
            var array = new int[x,y];
            Console.WriteLine("Massive is:");
            for (int ix = 0; ix < x; ix++)
            {
                for (int iy = 0; iy < y; iy++)
                {
                    array[ix,iy] = generator.Next(1000) - 500;
                    Console.Write($"{array[ix, iy]} ");
                }
                Console.WriteLine();
            }

            //solve
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

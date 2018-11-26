using System;

namespace Epam.Task2.NoPositive
{
    class Program
    {
        static void ShowNonPositive(int[,,] array, int x, int y, int z) // Написано что тип определяется, а задания для чисел
        {
            for (int ix = 0; ix < x; ix++)
            {
                for (int iy = 0; iy < y; iy++)
                {
                    for (int iz = 0; iz < z; iz++)
                    {
                        array[ix,iy,iz] = (array[ix, iy, iz]>0)?0: array[ix, iy, iz];
                        Console.Write($"{array[ix, iy, iz]} ");
                    }
                    Console.WriteLine();
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter coordinats of massive (x,y,z)");
            var generator = new Random();
            int.TryParse(Console.ReadLine(), out int x);
            int.TryParse(Console.ReadLine(), out int y);
            int.TryParse(Console.ReadLine(), out int z);
            int[,,] array = new int[x, y, z];
            for (int ix = 0; ix < x; ix++)
            {
                for (int iy = 0; iy < y; iy++)
                {
                    for (int iz = 0; iz < z; iz++)
                    {
                        array[ix, iy, iz] = generator.Next(1000)-500;
                    }
                }
            }
            ShowNonPositive(array,x,y,z);
        }
    }
}

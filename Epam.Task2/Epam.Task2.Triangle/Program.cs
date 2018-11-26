using System;
using System.Linq;

namespace Epam.Task2.XmasTree
{
    class Program
    {
        static void TriangleShow(int n)
        {
            if (n <= 0) throw new Exception("Wrong values!");
            //Enumerable.Range(1, n).ToList().ForEach(i=>Console.WriteLine(new string('*',i))); 
            
            for (int number = 1; number <= n; number++)
            {
                for (int singleString = 0; singleString < number; singleString++)
                {
                    Console.Write('*');
                }
                Console.Write(Environment.NewLine);
            }
        }
        static void Main(string[] args)
        {
        start:
            Console.WriteLine("Enter count of lines:");
            int.TryParse(Console.ReadLine(), out int n);
            Console.Clear();
            try
            {
                TriangleShow(n);
            }
            catch (Exception currentException)
            {
                Console.WriteLine($"FAIL! {currentException.Message}{Environment.NewLine}Try again:");
                goto start;
            }
        }
    }
}

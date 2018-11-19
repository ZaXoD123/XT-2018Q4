using System;

namespace Epam.Task1.Sequence
{
    class Program
    {
        public static void SequenceFunction(int n)
        {
            if (n < 1) throw new Exception("This number is wrong");
            //Console.WriteLine(String.Join(", ",Enumerable.Range(1, n).ToArray()));
            for (int i = 1; i < n; i++)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine(n); 
        }

        static void Main()
        { 
            Console.Write("Enter a positive integer [1+]: ");
            int.TryParse(Console.ReadLine(), out int n);
            SequenceFunction(n);
        }
    }
}

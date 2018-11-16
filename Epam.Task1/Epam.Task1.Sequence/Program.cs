using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1.Sequence
{
    class Program
    {
        public static string SequenceFunction(int n)
        {
            return String.Join(", ",Enumerable.Range(1, n).ToArray()); 
        }

        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(SequenceFunction(n));
        }
    }
}

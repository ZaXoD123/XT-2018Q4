using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.AverageStringLength
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            int countOfLetters = 0;
            int countOfWofds = 0;
            var a = Console.ReadLine()+".";
            for (int i = 1; i < a.Length; i++)
            {
                if (!char.IsLetter(a[i]) && char.IsLetter(a[i - 1]))
                {
                    countOfWofds++;
                }
                if (char.IsLetter(a[i]))
                {
                    countOfLetters++;
                }
            }
            Console.WriteLine(countOfLetters / countOfWofds);
        }
    }
}

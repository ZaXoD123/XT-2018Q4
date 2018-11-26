using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharDoubler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter strings:");
            var string1 = Console.ReadLine();
            var string2 = Console.ReadLine();
            foreach (var item in string1.Where(x => string2.Contains(x.ToString())))
            {
                string1 = string1.Replace(item.ToString(), $"{item}{item}");
                string2 = string2.Replace(item.ToString(), "");
            }
            Console.WriteLine(string1);
        }
    }
}

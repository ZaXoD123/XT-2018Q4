using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharDoubler
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter strings:");
            var string1 = new StringBuilder(Console.ReadLine());
            var string2 = new StringBuilder(Console.ReadLine());
            foreach (var item in string1.ToString().Where(x => string2.ToString().Contains(x.ToString())))
            {
                string1 = string1.Replace(item.ToString(), $"{item}{item}");
                string2 = string2.Replace(item.ToString(), string.Empty);
            }

            Console.WriteLine(string1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task5.ISeekYou
{
    public static class Search
    {
        public static IEnumerable<T> DoSearch<T>(this T[] array, Func<T, bool> condition)
        {
            foreach (var item in array)
            {
                if (condition(item))
                {
                    yield return item;
                }
            }
        }

        public static void DoSearchByDelegate(this int[] array) 
        {
            Console.WriteLine("Delegates: ");
            Func<int, bool> cond = (x) => x >= 0;
            array.DoSearch(cond).Show();
        }

        public static void DoSearchByAnonymous(this int[] array)
        {
            Console.WriteLine("Anonymous: ");
            array.DoSearch(delegate(int x) { return x > 0; }).Show();
        }

        public static void DoSearchByLambda(this int[] array)
        {
            Console.WriteLine("Lambda: ");
            array.DoSearch((x) => x >= 0).Show();
        }

        public static void DoSearchByLinq(this int[] array)
        {
            Console.WriteLine("Linq: ");
            array.Where((x) => x >= 0).Show();
        }

        private static void Show<T>(this IEnumerable<T> array)
        {
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine(Environment.NewLine);
        }
    }
}

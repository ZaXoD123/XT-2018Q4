using System;
using System.Threading;
using System.Threading.Tasks;
using SortD = Epam.Task5.CustomSort.Program;

namespace Epam.Task5.SortingUnit
{
    public static class Sorter<T>
    {
        private static event Action<object> SortStopped;

        public static void Sort(T[] array, Func<T, T, int> compare, int start, int stop) => SortD.Sort(array, compare, start, stop);
        
        public static async Task BeginSort(T[] array, Func<T, T, int> compare, int start, int stop, Action<object> callback, object callbackInput)
        {
            SortStopped += callback;
            await Task.Run(() => SortD.Sort(array, compare, start, stop));
            SortStopped?.Invoke(callbackInput);
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            var array = new[] { 1, 9, 8, 2, 5 };
            Func<int, int, int> compare = (z, x) => z == x ? 0 : (z - x) / Math.Abs(z - x);
            Action<object> callback = x => Console.WriteLine(x.ToString());

            var temp = Sorter<int>.BeginSort(array, compare, 0, array.Length - 1, callback, "Stopped");
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine('*');
                Thread.Sleep(1);
            }

            temp.Wait();
        }
    }
}
using System;
using System.Collections.Generic;

namespace Epam.Task4.WordFrequency
{
    internal class Program
    {
        private static void GetWordsCount(Dictionary<string, int> words, string message)
        {
            if (message == null)
            {
                throw new Exception("Wrong string");
            }

            foreach (var item in message.ToLower().Split('.', ' '))
            {
                if (string.IsNullOrEmpty(item))
                {
                    continue;
                }

                if (words.ContainsKey(item))
                {
                    words[item] = words[item] + 1;
                }
                else
                {
                    words.Add(item, 1);
                }
            }
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");
            var a = new Dictionary<string, int>();
            startInput:
            var input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Wrong values. Try again");
                goto startInput;
            }

            GetWordsCount(a, input);
            
            foreach (var item in a.Keys) Console.WriteLine($"{item} {a[item]}");
        }
    }
}
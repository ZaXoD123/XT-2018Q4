﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.MyString
{
    class Program
    {
        static void Main(string[] args)
        {
            MyString a = new MyString("Коля");
            MyString b = new MyString(" пидр");
            Console.WriteLine(a+b);
        }
    }
}

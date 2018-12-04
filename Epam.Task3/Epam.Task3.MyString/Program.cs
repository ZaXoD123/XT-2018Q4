namespace Epam.Task3.MyString
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            MyString a = new MyString("Test");
            MyString b = new MyString(" String");
            Console.WriteLine(a + b);
        }
    }
}

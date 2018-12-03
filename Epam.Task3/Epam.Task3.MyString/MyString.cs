using System;

namespace Epam.Task3.MyString
{
    internal class MyString
    {
        private readonly char[] @string;

        public MyString()
        {
        }

        private MyString(int length)
        {
            @string = new char[length];
        }

        public MyString(string alpha)
        {
            @string = alpha.ToCharArray();
        }

        public override string ToString()
        {
            return string.Concat(@string);
        }

        public static MyString operator +(MyString s1, MyString s2)
        {
            var result = new MyString(s1.@string.Length + s2.@string.Length);
            s1.@string.CopyTo(result.@string, 0);
            s2.@string.CopyTo(result.@string, s1.@string.Length);
            return result;
        }

        public static bool operator ==(MyString s1, MyString s2)
        {
            return s1.@string == s2.@string ? true : false;
        }

        public static bool operator !=(MyString s1, MyString s2)
        {
            return s1.@string != s2.@string ? true : false;
        }

        public static explicit operator MyString(string str)
        {
            return new MyString(str);
        }

        public static explicit operator string(MyString str)
        {
            return str.ToString();
        }

        public int? FirstIndexOf(char letter)
        {
            for (var i = 0; i < @string.Length; i++)
            {
                if (@string[i] == letter)
                {
                    return i;
                }
            }
            return null;
        }
    }
}
namespace Epam.Task3.MyString
{
    using System;

    internal class MyString
    {
        private readonly char[] myStringArray;

        public MyString()
        {
        }

        public MyString(string alpha)
        {
            this.myStringArray = alpha.ToCharArray();
        }

        private MyString(int length)
        {
            this.myStringArray = new char[length];
        }

        public static MyString operator +(MyString s1, MyString s2)
        {
            var result = new MyString(s1.myStringArray.Length + s2.myStringArray.Length);
            s1.myStringArray.CopyTo(result.myStringArray, 0);
            s2.myStringArray.CopyTo(result.myStringArray, s1.myStringArray.Length);
            return result;
        }

        public static bool operator ==(MyString s1, MyString s2)
        {
            return s1.myStringArray == s2.myStringArray ? true : false;
        }

        public static bool operator !=(MyString s1, MyString s2)
        {
            return s1.myStringArray != s2.myStringArray ? true : false;
        }

        public static explicit operator MyString(string str)
        {
            return new MyString(str);
        }

        public static explicit operator string(MyString str)
        {
            return str.ToString();
        }

        public override string ToString()
        {
            return string.Concat(this.myStringArray);
        }

        public int? FirstIndexOf(char letter)
        {
            for (var i = 0; i < this.myStringArray.Length; i++)
            {
                if (this.myStringArray[i] == letter)
                {
                    return i;
                }
            }

            return null;
        }
    }
}
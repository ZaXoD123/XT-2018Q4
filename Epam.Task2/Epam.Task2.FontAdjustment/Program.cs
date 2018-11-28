using System;

namespace Epam.Task2.FontAdjustment
{
    public class Program
    {
        [Flags]
        public enum FontProperties : int
        {
            bold = 1,
            italic,
            underline = 4
        }

        public static void Main(string[] args)
        {
            int properties = 0;
            while (true)
            {
                Console.Write("Параметры надписи: ");
                if (((FontProperties)properties & (FontProperties.bold | FontProperties.italic | FontProperties.underline)) == 0)
                {
                    Console.Write("None");
                }
                else
                {
                    foreach (FontProperties item in Enum.GetValues(typeof(FontProperties)))
                    {
                        Console.Write(((properties & (int)item) != 0) ? (item & (FontProperties)properties).ToString() + ", " : string.Empty);
                    }
                }

                Console.WriteLine("{0}Введите: {0}{1}{0}{2}{0}{3}", Environment.NewLine, "       1: " + FontProperties.bold, "       2: " + FontProperties.italic, "       3: " + FontProperties.underline);
                properties = properties ^ (int)Math.Pow(2, int.Parse(Console.ReadLine()) - 1);
            }
        }
    }
}

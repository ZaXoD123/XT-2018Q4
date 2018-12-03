using System;

namespace Epam.Task3.Triangle
{
    internal class Triangle
    {
        public Triangle(int a, int b, int c)
        {
            if (!(a + b > c && b + c > a && a + c > b)) throw new Exception("Wrong values!");
            LengthOfSides = (a, b, c);
        }

        private (int a, int b, int c) LengthOfSides { get; }

        public double GetTriangleArea()
        {
            //Heron`s formula
            var p = (LengthOfSides.a + LengthOfSides.b + LengthOfSides.c) / 2;
            return Math.Sqrt(p * (p - LengthOfSides.a) * (p - LengthOfSides.b) * (p - LengthOfSides.c));
        }

        public double GetPerimeter()
        {
            return LengthOfSides.a + LengthOfSides.b + LengthOfSides.c;
        }
    }
}
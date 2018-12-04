using System;

namespace Epam.Task3.Triangle
{
    internal class Triangle
    {
        public Triangle(int a, int b, int c)
        {
            if (!(a + b > c && b + c > a && a + c > b))
            {
                throw new Exception("Wrong values!");
            }

            this.LengthOfSides = (a, b, c);
        }

        private (int a, int b, int c) LengthOfSides { get; }

        public double GetTriangleArea()
        {
            var p = (this.LengthOfSides.a + this.LengthOfSides.b + this.LengthOfSides.c) / 2;
            return Math.Sqrt(p * (p - this.LengthOfSides.a) * (p - this.LengthOfSides.b) * (p - this.LengthOfSides.c));
        }

        public double GetPerimeter()
        {
            return this.LengthOfSides.a + this.LengthOfSides.b + this.LengthOfSides.c;
        }
    }
}
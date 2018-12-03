using System;

namespace Epam.Task3.Round
{
    internal class Round
    {
        public Round(double radius, double x, double y)
        {
            if (radius <= 0) throw new Exception("Incorrect input values!");
            Radius = radius;
            Coordinates = (x, y);
            Length = 2 * Math.PI * radius;
            RoundArea = Math.PI * radius * radius;
        }

        public double Radius { get; }
        public (double, double) Coordinates { get; }
        public double Length { get; }
        public double RoundArea { get; }
    }
}
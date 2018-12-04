namespace Epam.Task3.Round
{
    using System;

    public class Round
    {
        public Round(double radius, double x, double y)
        {
            if (radius <= 0)
            {
                throw new Exception("Incorrect input values!");
            }

            this.Radius = radius;
            this.Coordinates = (x, y);
            this.Length = 2 * Math.PI * radius;
            this.RoundArea = Math.PI * radius * radius;
        }

        public double Radius { get; }

        public (double, double) Coordinates { get; }

        public double Length { get; }

        public double RoundArea { get; }
    }
}
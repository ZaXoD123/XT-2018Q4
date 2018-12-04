using System;

namespace Epam.Task3.VectorGraphicsEditor
{
    internal class Circle : IFigure
    {
        public Circle(double radius, int x, int y)
        {
            if (radius <= 0)
            {
                throw new Exception("Incorrect input values!");
            }

            this.Radius = radius;
            this.Coordinates = (x, y);
        }

        public double Radius { get; }

        public (int x, int y) Coordinates { get; }

        public void ShowFigure()
        {
            Console.WriteLine("Figure: Circle{0}Coordinates: {1}, {2}{0}Radius: {3}", Environment.NewLine, this.Coordinates.x, this.Coordinates.y, this.Radius);
        }
    }
}
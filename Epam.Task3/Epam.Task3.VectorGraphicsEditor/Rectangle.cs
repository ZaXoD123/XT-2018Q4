using System;

namespace Epam.Task3.VectorGraphicsEditor
{
    public class Rectangle : IFigure
    {
        public Rectangle(int xStart, int yStart, int xEnd, int yEnd)
        {
            this.Diagonal = new Line(xStart, yStart, xEnd, yEnd);
        }

        public Line Diagonal { get; }

        public void ShowFigure()
        {
            Console.WriteLine("Figure: Rectangle{0}Top 1 coordinates: {1}, {2}{0}Top 2 coordinates: {3}, {4}", Environment.NewLine, this.Diagonal.Coordinates.xStart, this.Diagonal.Coordinates.yStart, this.Diagonal.Coordinates.xEnd, this.Diagonal.Coordinates.yEnd);
        }
    }
}

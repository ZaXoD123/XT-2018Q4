using System;

namespace Epam.Task3.VectorGraphicsEditor
{
    public class Line : IFigure
    {
        public Line(int xStart, int yStart, int xEnd, int yEnd)
        {
            this.Coordinates = (xStart: xStart, yStart: yStart, xEnd: xEnd, yEnd: yEnd);
        }

        public (int xStart, int yStart, int xEnd, int yEnd) Coordinates { get; }

        void IFigure.ShowFigure()
        {
            Console.WriteLine("Figure: Line{0}Start coordinates: {1}, {2}{0}End coordinates: {3}, {4}", Environment.NewLine, this.Coordinates.xStart, this.Coordinates.yStart, this.Coordinates.xEnd, this.Coordinates.yEnd);
        }
    }
}
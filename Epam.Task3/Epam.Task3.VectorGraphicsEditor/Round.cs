using System;

namespace Epam.Task3.VectorGraphicsEditor
{
    public class Round : Task3.Round.Round, IFigure
    {
        public Round(double radius, double x, double y) : base(radius, x, y)
        {
        }

        public void ShowFigure()
        {
            Console.WriteLine("Figure: Round{0}Coordinates: {1}, {2}{0}Radius: {3}{0}Area: {4}", Environment.NewLine, this.Coordinates.Item1, this.Coordinates.Item2, this.Radius, this.RoundArea);
        }
    }
}

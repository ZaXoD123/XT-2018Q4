using System;

namespace Epam.Task3.VectorGraphicsEditor
{
    internal class Ring : Task3.Ring.Ring, IFigure
    {
        public Ring(double firstRadius, double secondRadius, double x, double y) : base(firstRadius, secondRadius, x, y)
        {
        }

        public void ShowFigure()
        {
            Console.WriteLine("Figure: Ring{0}Coordinates: {1}, {2}{0}RadiusOuter: {3}{0}RadiusInner: {4}{0}Area: {5}", Environment.NewLine, this.FirstRingBase.Coordinates.Item1, this.FirstRingBase.Coordinates.Item2, this.FirstRingBase.Radius, this.SecondRingBase.Radius, this.RingArea);
        }
    }
}
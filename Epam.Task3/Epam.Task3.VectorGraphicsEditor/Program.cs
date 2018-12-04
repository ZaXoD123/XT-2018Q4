using System;

namespace Epam.Task3.VectorGraphicsEditor
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IFigure[] figureArray = 
            {
                new Line(1, 1, 2, 2),
                new Rectangle(1, 1, 2, 2),
                new Circle(10, 1, 1),
                new Round(10, 1, 1), 
                new Ring(11, 10, 1, 1)
            };

            foreach (var figure in figureArray)
            {
                figure.ShowFigure();
                Console.WriteLine();
            }
        }
    }
}
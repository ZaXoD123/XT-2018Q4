using System;
using System.Collections.Generic;

namespace Epam.Task3.VectorGraphicsEditor
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<IFigure> figureArray = new List<IFigure>();
            
            Console.WriteLine("What type of figure you want to create?{0} 1. Line{0} 2. Rectangle{0} 3. Circle{0} 4. Round{0} 5. Ring{0} -1. Show and exit", Environment.NewLine);
            startInput:
            Console.Write($"{Environment.NewLine}> ");
            int.TryParse(Console.ReadLine(), out int input);
            switch (input)
            {
                case 1:
                    var temp = Creator.Create(ref figureArray, Creator.CreateLine, "xStart yStart xEnd yEnd", 4);
                    if (!temp)
                    {
                        goto default;
                    }

                    goto startInput;
                case 2:
                    temp = Creator.Create(ref figureArray, Creator.CreateRectangle, "xStart yStart xEnd yEnd", 4);
                    if (!temp)
                    {
                        goto default;
                    }

                    goto startInput;
                case 3:
                    temp = Creator.Create(ref figureArray, Creator.CreateCircle, "Radius x y", 3);
                    if (!temp)
                    {
                        goto default;
                    }

                    goto startInput;
                case 4:
                    temp = Creator.Create(ref figureArray, Creator.CreateRound, "Radius x y", 3);
                    if (!temp)
                    {
                        goto default;
                    }

                    goto startInput;
                case 5:
                    temp = Creator.Create(ref figureArray, Creator.CreateRing, "FirstRadius SecondRadius x y", 4);
                    if (!temp)
                    {
                        goto default;
                    }

                    goto startInput;
                case -1:
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Wrong value. Try again");
                    goto startInput;
            }

            foreach (var figure in figureArray)
            {
                figure.ShowFigure();
                Console.WriteLine();
            }
        }
    }
}
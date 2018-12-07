using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.VectorGraphicsEditor
{
    public delegate IFigure CreatorMethod(params int[] parameters);

    public static class Creator
    {
        public static IFigure CreateLine(params int[] parameters)
        {
            try
            {
                return new Line(parameters[0], parameters[1], parameters[2], parameters[3]);
            }
            catch
            {
                return null;
            }
        }

        public static IFigure CreateCircle(params int[] parameters)
        {
            try
            {
                return new Circle(parameters[0], parameters[1], parameters[2]);
            }
            catch
            {
                return null;
            }
        }

        public static IFigure CreateRectangle(params int[] parameters)
        {
            try
            {
                return new Rectangle(parameters[0], parameters[1], parameters[2], parameters[3]);
            }
            catch
            {
                return null;
            }
        }

        public static IFigure CreateRing(params int[] parameters)
        {
            try
            {
                return new Ring(parameters[0], parameters[1], parameters[2], parameters[3]);
            }
            catch 
            {
                return null;
            }
        }

        public static IFigure CreateRound(params int[] parameters)
        {
            try
            {
                return new Round(parameters[0], parameters[1], parameters[2]);
            }
            catch 
            {
                return null;
            }
        }
        
        internal static bool Create(ref List<IFigure> figures, CreatorMethod creationMethod, string message, int count)
        {
            IFigure tempResult;
            try
            {
                tempResult = creationMethod.Invoke(GetParametersFromConsole(message, count).parameters);
            }
            catch 
            {
                return false;
            }

            if (tempResult == null)
            {
                return false;
            }

            figures.Add(tempResult);
            return true;
        }

        private static (bool error, int[] parameters) GetParametersFromConsole(string message, int count)
        {
            Console.WriteLine($"Enter this parameters: ");
            var paramNames = message.Split(' ');
            var tempArray = new int[count];
            if (paramNames.Length != count)
            {
                throw new Exception("Bad values!");
            }

            for (var i = 0; i < count; i++)
            {
                Console.WriteLine($"{paramNames[i]}: ");
                if (!int.TryParse(Console.ReadLine(), out tempArray[i]))
                {
                    throw new Exception("Bad values!");
                }
            }

            return (false, tempArray);
        }
    }
}

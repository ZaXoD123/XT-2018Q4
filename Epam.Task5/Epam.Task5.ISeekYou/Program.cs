using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task5.ISeekYou
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new int[] { 1, 2, -2, 3, -3 };
            a.DoSearchByDelegate();
            a.DoSearchByAnonymous();
            a.DoSearchByLambda();
            a.DoSearchByLinq();
        }
    }
}

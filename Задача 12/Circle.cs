using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_12
{
    static internal class Circle
    {
        static public double GetLength(double r)
        {
            return 2*Math.PI * r;
        }
        static public double GetSquare(double r)
        {
            return Math.PI *r*r;
        }
        static public double GetTochka(double x, double y)
        {
            return Math.Sqrt(x*x+y*y);
        }
                   
    }
}

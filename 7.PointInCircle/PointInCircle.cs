using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.PointInCircle
{
    class PointInCircle
    {
        static void Main(string[] args)
        {
            double x = Math.Abs(0.9);
            double y = Math.Abs(-1.93);
            double distance = Math.Sqrt((x * x) + (y * y));
           
            if (distance <= 2)
            {
                Console.WriteLine("The point is INSIDE the circle!");
            }
            else
            {
                Console.WriteLine("The point is OUTSIDE the circle!");
            }
        }
    }
}

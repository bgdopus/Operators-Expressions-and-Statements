using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PointInCircleOutRectangle
{
    class PointInCircleOutRectangle
    {
        static void Main(string[] args)
        {
            double centerX = 1;
            double centerY = 1;
            double x = 2;
            double y = 1.5;
            double distance = Math.Sqrt(Math.Pow(x - centerX, 2) + Math.Pow(y-centerY, 2));
            if (distance < 1.5)
            {
                if (y < 1 && y > -1)
                {
                    Console.WriteLine("NO");
                }
                else
                {
                    Console.WriteLine("YES");
                }
            }
            else
            {
                Console.WriteLine("Outside the Circle");
            }
        }
    }
}

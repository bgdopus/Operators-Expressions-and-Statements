using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Rectangles
{
    class Rectangles
    {
        static void Main(string[] args)
        {
            double width = 2.5;
            double lenght = 3;
            double perimeter = (2 * width) + (2 * lenght);
            double area = width * lenght;
            Console.WriteLine("The perimeter is - " +perimeter);
            Console.WriteLine("The area is - " + area);

        }
    }
}

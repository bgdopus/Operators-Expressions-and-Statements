using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main(string[] args)
        {
            int number = 2011;
            int d = number % 10;
            int c = ((number / 10) % 10);
            int b = ((number / 100) % 10);
            int a = number / 1000;
            Console.WriteLine(a+b+c+d);
            Console.WriteLine(d.ToString()+c.ToString()+b.ToString()+a.ToString());
            Console.WriteLine(d.ToString() + a.ToString() + b.ToString() + c.ToString());
            Console.WriteLine(a.ToString() + c.ToString() + b.ToString() + d.ToString());
        }
    }
}

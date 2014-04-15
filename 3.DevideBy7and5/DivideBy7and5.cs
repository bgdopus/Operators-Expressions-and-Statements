using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DevideBy7and5
{
    class DivideBy7and5
    {
        static void Main(string[] args)
        {
            int number = 35;
            if (number % 7 == 0)
            {
                if (number % 5 == 0)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
            else 
            {
                Console.WriteLine("False");
            }
        }
    }
}

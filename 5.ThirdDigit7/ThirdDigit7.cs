using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.ThirdDigit7
{
    class ThirdDigit7
    {
        static void Main(string[] args)
        {
            int number = 9703;
            int result = number / 100;
            if (result != 0)
            {
                int lastNumbet = result % 10;
                if (lastNumbet == 7)
                {
                    Console.WriteLine("The last numbet is = " + lastNumbet);
                }
                else
                {
                    Console.WriteLine("The last digit is different than 7!");
                }
            }
            else
            {
                Console.WriteLine("The number is less than three digits!");
            }
        }
    }
}

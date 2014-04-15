using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ExtractBit3
{
    class ExtractBit3
    {
        static void Main(string[] args)
        {
            int n = 5343;
            int p = 7;
            int i = 1;
            int mask = i << p;
            Console.WriteLine((n & mask) !=0 ? 1 : 0); 

        }
    }
}

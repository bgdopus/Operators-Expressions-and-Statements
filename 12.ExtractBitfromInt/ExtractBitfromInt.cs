using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ExtractBitfromInt
{
    class ExtractBitfromInt
    {
        static void Main(string[] args)
        {
            int n = 13;
            int p = 1;
            int i = 1;
            int mask = i << p;
            Console.WriteLine((n & mask) != 0 ? 1 : 0); 
        }
    }
}

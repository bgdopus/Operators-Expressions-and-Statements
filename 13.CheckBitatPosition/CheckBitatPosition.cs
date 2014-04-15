using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.CheckBitatPosition
{
    class CheckBitatPosition
    {
        static void Main(string[] args)
        {
            int n = 5343;
            int p = 7;
            int i = 1;
            int mask = i << p;
            Console.WriteLine((n & mask) != 0 ? true : false); 
        }
    }
}

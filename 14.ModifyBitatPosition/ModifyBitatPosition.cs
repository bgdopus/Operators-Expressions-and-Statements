using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ModifyBitatPosition
{
    class ModifyBitatPosition
    {
        static void Main(string[] args)
        {
            int n = 0;
            int p = 9;
            int v = 1;
           
            n = n & (~(1 << p));
            n = n | (v<<p);
            Console.WriteLine(n); 
        }
    }
}

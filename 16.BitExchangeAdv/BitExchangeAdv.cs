using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.BitExchangeAdv
{
    class BitExchangeAdv
    {
        static void Main(string[] args)
        {
            uint n = 1140867093;

            byte p = 3;
            byte q = 24;
            byte k = 3;
            uint mask = 1;

            for (int i = 0; i < p; i++)
            {
                mask *= 2;
            }

            uint getFirstBits = (((mask - 1) << q) & n) >> q;
            uint getSecondBits = (((mask - 1) << k) & n) >> k;

            n = n & (~((mask - 1) << q));
            n = n & (~((mask - 1) << k));
            n = n | (getFirstBits << k);
            n = n | (getSecondBits << q);

            Console.WriteLine(n);
        }
    }
}

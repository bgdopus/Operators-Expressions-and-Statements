using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.BitsExchange
{
    class BitsExchange
    {
        static void Main(string[] args)
        {
            int n = 5351;
            int p3 = 3;
            int mask3 = 1 << p3;
            int bit3 = ((n & mask3) !=0 ? 1 : 0);

            int p4 = 4;
            int mask4 = 1 << p4;
            int bit4 = ((n & mask4) != 0 ? 1 : 0);

            int p5 = 5;
            int mask5 = 1 << p5;
            int bit5 = ((n & mask5) != 0 ? 1 : 0);

            Console.Write("bit5-"+bit5);
            Console.Write("bit4-" + bit4);
            Console.WriteLine("bit3-" + bit3);
            Console.WriteLine("------------");

            
            int p24 = 24;
            int mask24 = 1 << p24;
            int bit24 = ((n & mask24) != 0 ? 1 : 0);

            int p25 = 25;
            int mask25 = 1 << p25;
            int bit25 = ((n & mask25) != 0 ? 1 : 0);

            int p26 = 26;
            int mask26 = 1 << p26;
            int bit26 = ((n & mask26) != 0 ? 1 : 0);

            Console.Write("bit26-" + bit26);
            Console.Write("bit25-" + bit25);
            Console.WriteLine("bit24-" + bit24);
            Console.WriteLine("------------");

            int temp3 = bit3;
            bit3 = bit24;
            bit24 = temp3;
            n = n & (~(1 << p3));
            n = n | (bit3 << p3);
            n = n & (~(1 << p24));
            n = n | (bit24 << p24);
            Console.WriteLine("bit3-" + bit3);
            Console.WriteLine("bit24-" + bit24);

            int temp4 = bit4;
            bit4 = bit25;
            bit25 = temp4;
            n = n & (~(1 << p4));
            n = n | (bit4 << p4);
            n = n & (~(1 << p25));
            n = n | (bit25 << p25);
            Console.WriteLine("bit4-" + bit4);
            Console.WriteLine("bit25-" + bit25);

            int temp5 = bit5;
            bit5 = bit26;
            bit26 = temp5;
            n = n & (~(1 << p5));
            n = n | (bit5 << p5);
            n = n & (~(1 << p26));
            n = n | (bit26 << p26);
            Console.WriteLine("bit5-" + bit5);
            Console.WriteLine("bit26-" + bit26);

            Console.WriteLine(n);
            

        }
    }
}

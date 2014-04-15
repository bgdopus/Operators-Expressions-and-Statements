using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.MoonGravitation
{
    class MoonGravitation
    {
        static void Main(string[] args)
        {
            double earthWeight = 86;
            double? moonWeight = 0;
            moonWeight = earthWeight * 0.17;
            Console.WriteLine(moonWeight);
        }
    }
}

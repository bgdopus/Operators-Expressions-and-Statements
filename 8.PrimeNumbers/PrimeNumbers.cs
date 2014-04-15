using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.PrimeNumbers
{
    class PrimeNumbers
    {
        static void Main(string[] args)
        {

            
            bool isPrime = true;
            
            for (int i = 2; i <= 100; i++)
            {
                for (int j = 2; j <= 100; j++)
                {

                    if (i != j && i % j == 0)
                    {
                        isPrime = false;

                        break;
                    }


                }

                if (isPrime)
                {
                    Console.WriteLine("Prime:" + i);
                }

                isPrime = true;
            }

            


        }
       
    }

}

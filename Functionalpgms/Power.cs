using System;
using System.Collections.Generic;
using System.Text;

namespace Functionalpgms
{
    public class Power
    {
        public void highest()
        {
            int n = 31;
            int i = 0;
            int power = 1;
            Console.WriteLine("power of 2 that are less than 2^" + 31);
            while (i <= n)
            {
                Console.WriteLine("2^" + i + "=" + power);
                power = power * 2;
                i++;
            }
        }
    }
}
            

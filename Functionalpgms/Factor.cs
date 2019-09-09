using System;
using System.Collections.Generic;
using System.Text;

namespace Functionalpgms
{
    class Factor
    {
        public void fact()
        {
            Console.WriteLine("Enter Number:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("prime factor of" + number + "is:");
            findPrimeFactor(number);

        }

        public void findPrimeFactor(int number)
        {
            for (int i = 1; i * i <= number; i++)
                if (number % i == 0)
                    Console.WriteLine("" + i);

        }

    }
}

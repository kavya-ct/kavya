// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Primenumbers.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kavya ct"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithmpgm
{
    /// <summary>
    /// Prime is the class
    /// </summary>
    class Primenumbers
    {
        /// <summary>
        /// Primes this instance.
        /// </summary>
        public void Prime()
        {
            int num, i, stno, enno;
            Console.WriteLine("Find the primenumbers within a range");
            Console.WriteLine("Input starting number of range:");
            stno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input ending number of range:");
            enno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the primenumbers between {0} and {1000} are:\n");

            ////main logic to find prime numbers
            ///between 0 to 1000

            for (num = stno; num < enno; num++)
            {

                for (i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        break;
                    }
                }
                if (i == num)
                    Console.WriteLine(num + " ");
            }


        }
    }

}

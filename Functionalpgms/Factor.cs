// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Factor.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kavya ct"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Functionalpgms
{
    /// <summary>
    /// Factor is a class name
    /// </summary>
    class Factor
    {
        /// <summary>
        /// factor 
        /// </summary>
        public void fact()
        {
            Console.WriteLine("Enter Number:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("prime factor of" + number + "is:");

            ////asks for input of prime factors
            findPrimeFactor(number);

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        public void findPrimeFactor(int number)
        {
            ////M
            ///
            /// 
            /// 
            /// 
            /// 
            /// ain method
            for (int i = 1; i * i <= number; i++)
                if (number % i == 0)
                    Console.WriteLine("" + i);

        }

    }
}

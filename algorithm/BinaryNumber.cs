// --------------------------------------------------------------------------------------------------------------------
// <copyright file=BinaryNumber.cs" company="Bridgelabz">
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
    /// BinaryNumber is the class
    /// </summary>
    public class BinaryNumber
    {
        /// <summary>
        /// Binaries this instance.
        /// </summary>
        public void Binary()
        {
            int i;

            Console.WriteLine("enter the value of n");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[10];
            for(i = 0; n > 0; i++)
            {
                a[i] = n % 2;
                n = n / 2;
            }
            Console.WriteLine("Converting Decimal no.");
            for(i = i - 1; i >= 0; i--)
            {
                Console.Write(a[i]);
            }
        }
    }
}

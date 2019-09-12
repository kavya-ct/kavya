// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Power.cs" company="Bridgelabz">
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
    /// 
    /// </summary>
    public class Power
    {
        /// <summary>
        /// Highests this instance.
        /// </summary>
        public void highest()
        {
            int n = 31;
            int i = 0;
            int power = 1;
            Console.WriteLine("power of 2 that are less than 2^" + 31);
            ////
            ///
            while (i <= n)
            {
                Console.WriteLine("2^" + i + "=" + power);
                power = power * 2;
                i++;
            }
        }
    }
}
            

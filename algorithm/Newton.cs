// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Newton.cs" company="Bridgelabz">
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
    /// Newton is the class name
    /// </summary>
    public class Newton
    {
        /// <summary>
        /// Laws this instance.
        /// </summary>
        public static void Sqrt()
        {
            Console.WriteLine("enter the value");
            
            ////read in the command-line argument
            double c = Convert.ToDouble(Console.ReadLine());
            double epsilon = 1e-15;
            double t = c;
            //// repeatedly apply Newton update step until desired precision is achieved
            while (Math.Abs(t - c/t) > epsilon*t)
            {
                
                t = (c / t + t) / 2.0;
                Console.WriteLine(t);

            }
            Console.ReadLine();

            //// print out the estimate of the square root of c

        }
    }
}



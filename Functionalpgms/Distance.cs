// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Distance.cs" company="Bridgelabz">
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
    /// Distance is class
    /// </summary>
    class Distance
    {
        /// <summary>
        /// Calculates this instance.
        /// </summary>
        public void Calculate()
        {
            ////Reading of x and y from user for 2nd coordinate number
            Console.WriteLine("Enter first coordinate number");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());


            ////Reading of x and y from user for 2nd coordinate number
            Console.WriteLine("Enter second coordinate number");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());

            ////squareroot of (x-a)^2
            double root1 = Math.Pow((x - a), 2);

            ////squareroot of (y-b)^2
            double root2 = Math.Pow((y - b), 2);

            if(x > a && y > b)
            {
                ////squareroot of (x-a)^2+(y-b)^2
                double dist = Math.Sqrt(root1 + root2);
                Console.WriteLine("Distance is:" + dist);
            }








        }

    }
}

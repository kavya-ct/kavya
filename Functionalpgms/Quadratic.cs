// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Quadratic.cs" company="Bridgelabz">
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
    /// Quadratic is a class
    /// </summary>
    public class Quadratic
    {
        /// <summary>
        /// Finds the roots.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <param name="c">The c.</param>
        public void findRoots(int a, int b, int c)
        {
            //If a is 0,then equation is
            //not quadratic,but linear

            if (a == 0)
            {
                Console.Write("Invalid");
                return;
            }

            int d = b * b - 4 * a * c;
            double sqrt_val = Math.Abs(d);

            if(d > 0)
            {
                Console.Write("Roots are real and different\n");

                Console.Write((double)(-b + sqrt_val) /
                     (2 * a) + "\n" + (double)
                     (-b - sqrt_val) / (2 * a));
            }

            //d < 0
            else
            {
                Console.Write("Roots are complex \n");

                Console.Write(-(double)b / (2 * a) + " + i" + sqrt_val + "\n" +
                      -(double)b / (2 * a) +
                           " - i" + sqrt_val);
            }


        }

        }
        
    }


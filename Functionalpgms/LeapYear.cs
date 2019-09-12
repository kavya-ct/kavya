// --------------------------------------------------------------------------------------------------------------------
// <copyright file=LeapYear.cs" company="Bridgelabz">
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
    /// LeapYear is a class name
    /// </summary>
    public class LeapYear
    {
        /// <summary>
        /// The year instsance
        /// </summary>
        
        Utility utility = new Utility();
           

        public void readdata()
        {
            //  Console.WriteLine("Enter the Year in four digits:");
            //  Year = int.Parse(Console.ReadLine());
            int Year = utility.CallInt();
            ////asks for input in 4 digits number
            ///
            if (Year > 1000)
            {


                if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
                {
                    Console.WriteLine("{0} is a leap year", Year);
                }
                else
                {
                    Console.WriteLine("{0} is not a leap year", Year);
                }

                Console.ReadLine();
            }
        }
    }
}
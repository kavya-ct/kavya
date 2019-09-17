// --------------------------------------------------------------------------------------------------------------------
// <copyright file=MonthlyPayment.cs" company="Bridgelabz">
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
    /// MonthlyPayment is the class
    /// </summary>
    public class MonthlyPayment
    {
        /// <summary>
        /// Pays this instance.
        /// </summary>
        public void Pay()
        {
            Console.WriteLine("Enter the loan amount");
            double principal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the year");
            double year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the rate of interest");
            double rate = Convert.ToDouble(Console.ReadLine());
            double n = 12 * year;
            double r = rate / (12 * 100);

            ////using the formula by using required function
            double payment = (principal*r)/(1-Math.Pow((1+r),-n));
            Console.WriteLine(Math.Round(payment));

        }
    }
}

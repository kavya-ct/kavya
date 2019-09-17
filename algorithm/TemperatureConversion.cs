// --------------------------------------------------------------------------------------------------------------------
// <copyright file=TemperatureConversion.cs" company="Bridgelabz">
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
    /// TemperatureConversion is the class 
    /// </summary>
    public class TemperatureConversion
    {
        /// <summary>
        /// instance
        /// </summary>
        public void Sqrt()
        {
            double f, c;
            Console.WriteLine("choose type of conversion \n 1.Fahrenheit to Celsius  \n 2.Celsius to Fahrenheit");
            int ch;
            ch = int.Parse(Console.ReadLine());
           
            

            switch(ch)
            {
                ////convert Fahreneit to celcius
                case 1:
                    Console.WriteLine("Enter Fahrenheit temperature");
                    f = Convert.ToDouble(Console.ReadLine());
                    c = (f - 32) * 5 / 9;
                    Console.WriteLine("Celcius temperature is = " + c);
                    break;

                    ////Convert Celcius to Fahreneit
                case 2:
                    Console.WriteLine("Enter Celsius temperature");
                    c = Convert.ToDouble(Console.ReadLine());
                    f = ((9 * c) / 5) + 32;
                    Console.WriteLine("Fahrenheit temperature is = " + f);
                    break;

                default:
                    Console.WriteLine("please choose valid choice");
                    break;

            }
            
        }

    }
}

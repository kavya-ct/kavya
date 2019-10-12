// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Calender.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kavya ct"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    /// <summary>
    /// CalenderWeek is the class
    /// </summary>
    public class CalenderWeek
    {
        /// <summary>
        /// Calenders this instance.
        /// </summary>
        public void Calender()
        {
            Console.WriteLine("enter month");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter year");
            int year = Convert.ToInt32(Console.ReadLine());
            int day = 1, space = 0;

            
            int year0 = year - (14 - month) / 12;
            int x = year0 + year0 / 4 - year0 / 100 + year0 / 400;
            int month0 = month + 12 * ((14 - month) / 12) - 2;
            int day0 = (day + x + (31 * month0) / 12) % 7;
            int days = 1;
            Console.WriteLine(day0);
            Console.WriteLine(" " + year + " " + month);
            Console.WriteLine(" ");
            ////Switch cases to find the no. of day in month
            switch(month)
            {
                case 1:
                    days = 31;
                    break;

                case 2:
                    days = 28;
                    break;

                case 3:
                    days = 31;
                    break;

                case 4:
                    days = 30;
                    break;

                case 5:
                    days = 31;
                    break;

                case 6:
                    days = 30;
                    break;

                case 7:
                    days = 31;
                    break;

                case 8:
                    days = 31;
                    break;

                case 9:
                    days = 30;
                    break;

                case 10:
                    days = 31;
                    break;

                case 11:
                    days = 30;
                    break;

                case 12:
                    days = 31;
                    break;

                default:
                    Console.WriteLine("no match found");
                    break;

               
            }

            Console.WriteLine(" " + "sun" + " " + "mon" + " " + "tue" + " " + "wed" + " " + "thu" + " " + "fri" + " " + "sat");
            for(int i = 0; i<7; i++)
            {
                for(int j = 0; j < 1; j++)
                {
                    if(space < day0)
                    {
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine(days);
                        days++;
                    }
                }
            }
            }
    }
}

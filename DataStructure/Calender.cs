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
    /// Calender is the class
    /// </summary>
    public class Calender
    {

        Utility utility = new Utility();
        /// <summary>
        /// Prints the calender.
        /// </summary>
        public  void PrintCalender()
        {
            int month = 0, year = 0;
            bool ValidationforMonth = true;
            try
            {
                ////month(jan=1; to Dec=12)
                while (ValidationforMonth)
                {
                    Console.WriteLine("Enter the month in Number");
                    string stringMonth = Console.ReadLine();
                    if (Utility.IsNumber(stringMonth) == false)
                    {
                        Console.WriteLine("Invalid Month");
                        continue;
                    }
                    month = Convert.ToInt32(stringMonth);
                    if (month <= 0 || month > 12)
                    {
                        Console.WriteLine("Invalid month");
                        continue;
                    }
                    ValidationforMonth = false;
                }
                bool validationforYear = true;
                while (validationforYear)
                {
                    Console.WriteLine("enter the year");
                    string stringYear = Console.ReadLine();
                    if (Utility.IsNumber(stringYear) == false)
                    {
                        Console.WriteLine("Invalid Year");
                        continue;
                    }
                    if (stringYear.Length < 4)
                    {
                        Console.WriteLine("invalid year");
                        Console.Read();
                        return;
                    }
                    year = Convert.ToInt32(stringYear);
                    validationforYear = false;
                }
                string[] monthName = { " ", "january", "february", "march", "april", "may", "june", "july", "august", "september", "october", "november", "december" };
                int[] numberofday = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                ////for LeapYear check
                if (month == 2 && Utility.isLeapYear(year)) numberofday[month] = 29;

                Console.WriteLine("\t\t\t" + monthName[month] + " " + year);
                Console.WriteLine();
                Console.WriteLine("su\tm\tTu\tw\tTh\tf\tSa");
                ////weekdays where month start
                int d = Utility.day(month, 1, year);
                   
                for (int j = 0; j < d; j ++)
                {
                    Console.Write(" \t");

                }
                for (int i = 1; i <= numberofday[month]; i++)
                {
                    Console.Write(i + "\t");
                    if (((i + d) % 7 == 0) || (i == numberofday[month]))
                        Console.WriteLine();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}









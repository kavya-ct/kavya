using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
   public class Calender
    {
        public static void PrintCalender()
        {
            int month = 0, year = 0;
            bool ValidationforMonth = true;
            ;

        }
        public static int day(int month, int day, int year)

        {
            int y = year - (14 - month) / 12;
            int x = y + y / 4 - y / 100 + y / 400;
            int m = month + 12 * ((14 - month) / 12) - 2;
            int d = (day + x + (31 * m) / 12) % 7;
            return d;
        }

        // return true if the given year is a leap year
        public static Boolean isLeapYear(int year)
        {
            if ((year % 4 == 0) && (year % 100 != 0)) return true;
            if (year % 400 == 0) return true;
            return false;
        }
        public void Year()
        {
            int month = Convert.ToInt32(Console.ReadLine());   
            int year = Convert.ToInt32(Console.ReadLine());    

            // months[i] = name of month i
            String[] months = {
            "",                               
            "January", "February", "March",
            "April", "May", "June",
            "July", "August", "September",
            "October", "November", "December" };
        


        // days[i] = number of days in month i
        int[] days = {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};


            // check for leap year
            if (month == 2 && isLeapYear(year)) days[month] = 29;


            // print calendar header
            Console.WriteLine("   " + months[month] + " " + year);
            Console.WriteLine(" S  M Tu  W Th  F  S");

            // starting day
            int d = day(month, 1, year);

            // print the calendar
            for (int i = 0; i < d; i++)
                Console.WriteLine("   ");
            for (int i = 1; i <= days[month]; i++)
            {
                Console.WriteLine("%2d ", i);
                if (((i + d) % 7 == 0) || (i == days[month])) Console.WriteLine();
            }

        }
    }

}


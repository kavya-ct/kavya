using System;
using System.Collections.Generic;
using System.Text;

namespace Functionalpgms
{
    public class LeapYear
    {
        int Year;

        public void readdata()
        {
            Console.WriteLine("Enter the Year in four digits:");
            Year = int.Parse(Console.ReadLine());
        

        
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
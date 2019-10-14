// --------------------------------------------------------------------------------------------------------------------
// <copyright file=RegularExpression.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kavya ct"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace ObjectOrientedPrograms.REGEX
{
    /// <summary>
    /// RegularExpression is the class
    /// </summary>
    public class RegularExpression
    {
        /// <summary>
        /// Expressions this instance.
        /// </summary>
        public void Expression()
        {
            try
            {
                ////ask user to input name
                Console.WriteLine("enter your name");
                string name = Console.ReadLine();
                ////string name in regex form
                if (!Regex.IsMatch(name, @"[a-zA-Z]"))
                {
                    Console.WriteLine("enter wrong input");

                }
                Console.WriteLine("enter your full name");
                string fullname = Console.ReadLine();
                if (!Regex.IsMatch(fullname, @"[a-zA-Z]"))
                {
                    Console.WriteLine("enter wrong input");
                }
                Console.WriteLine("enter mobile no.");
                string num = Console.ReadLine();
                if (!Regex.IsMatch(num, @"^[0-9]{10}$"))
                {
                    Console.WriteLine("enter wrong input");

                }
                check(name, fullname, num);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        public void check(string name,string fullname,string num)
        {
            ////path which hold check message
            string text = File.ReadAllText(@"C:\Users\Bridgelabz\source\repos\ObjectOrientedPrograms\ObjectOrientedPrograms\REGEX\Regexfile.txt");
            string patternname = "<<name>>";
            string patternfullname = "<<full name>>";
            string patternnum = "xxxxxxxxxx";
            string patterndate = "27/09/2019";
            text = Display(text, name, patternname);
            text = Display(text, fullname, patternfullname);
            text = Display(text, num, patternnum);
            string date = DateTime.Now.ToString();
            text = Display(text, date, patterndate);
            Console.WriteLine();
            Console.WriteLine(text);

        }

        public static string Display(string text,string exp,string pattern)
        {
            Regex rxg = new Regex(pattern);
            string newString = rxg.Replace(text,exp);
            return newString;


        }

        

        
    }
}

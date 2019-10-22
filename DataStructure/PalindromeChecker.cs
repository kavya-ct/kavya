// --------------------------------------------------------------------------------------------------------------------
// <copyright file=PalindromeChecker.cs" company="Bridgelabz">
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
    /// PalindromeChecker is the class
    /// </summary>
    public class PalindromeChecker
    {
        Utility utility = new Utility();
        /// <summary>
        /// Checkers this instance.
        /// </summary>
        public void Checker()
        {
            try
            {
                Console.WriteLine("Enter the string");
                string word = Console.ReadLine();
                char[] ch = new char[30];
                ////Converting String to Character
                ch = word.ToCharArray();
                Console.WriteLine(ch);
                string s1 = " ";
                ////sorting the character array to list by converting them to string
                for(int i = ch.Length - 1; i >= 0; i--)
                {
                    utility.Enqueue(ch[i].ToString());
                    s1 += ch[i];
                    //Console.WriteLine();
                }
                string s2 = " ";
                ////Dequeue of the element
                for(int i =0; i<ch.Length; i++)
                {
                    utility.Dequeue(ch[i].ToString());
                    s2 += ch[i];
                }
                ////condition to check the elements added and deleted if same palindrome or not
                if(s1 == s2)
                {
                    Console.WriteLine("palindrome");
                }
                else
                {
                    Console.WriteLine("is not a palindrome");
                }
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

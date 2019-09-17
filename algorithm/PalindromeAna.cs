// --------------------------------------------------------------------------------------------------------------------
// <copyright file=PalindromeAna.cs" company="Bridgelabz">
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
    /// PalindromeAna is the class
    /// </summary>
    public class PalindromeAna
    {
        /// <summary>
        /// Palindromes this instance.
        /// </summary>
        public void Palindrome()
        {

            int num;
            Console.WriteLine("enter the number");
            num = Convert.ToInt32(Console.ReadLine());

           
            for (int m = 0; m < num; m++)
            {
                int rem;
                int revNum = 0;
                int num1 = num;

                while (num > 0)
                {
                    rem = num % 10;
                    revNum = revNum * 10 + rem;
                    num = num / 10;
                }

                if (revNum == num1)
                {
                    Console.WriteLine("Palindrome"  + " ");
                }
                else
                {
                    Console.WriteLine("not Palindrome");
                }

            }


        }
    }

}
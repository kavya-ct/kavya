// --------------------------------------------------------------------------------------------------------------------
// <copyright file=BinarySearch.cs" company="Bridgelabz">
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
    /// BinarySearch is the class
    /// </summary>
    class BinarySearch
    {
        Utility utility = new Utility();

        /// <summary>
        /// Searches this instance.
        /// </summary>
        public void Search()
        {
            try
            {
                ////using exception handling method
                int num = 0;
                bool iterate = true;
                while(iterate)
                {
                    Console.WriteLine("enter the number of element");
                    string element = Console.ReadLine();
                   // if(Utility.IsNumber(element) == false)
                    {
                        Console.WriteLine("invalid input");
                        continue;
                    }
                    num = Convert.ToInt32(element);
                    if(num < 0)
                    {
                        Console.WriteLine("element should be greater than zero");
                        continue;
                    }
                    iterate = false;
                }
                int numBinaryTree = Utility.CountBinarySearch(num);
                Console.WriteLine("Number possible of binary tree=" + numBinaryTree);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

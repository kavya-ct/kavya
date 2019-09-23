// --------------------------------------------------------------------------------------------------------------------
// <copyright file=BalancedParanthesis.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kavya ct"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DataStructure
{
    /// <summary>
    /// BalancedParanthesis is the class name
    /// </summary>
    public class BalancedParanthesis
    {

        
        Utility utility = new Utility();

        /// <summary>
        /// Paranthesises this instance.
        /// </summary>
        public void Paranthesis()
        { 

       
        try
            {
                string text = File.ReadAllText(@"C:\Users\Bridgelabz\Desktop\paranthesis.txt");
        String[] arr = text.Split(' ');
        Console.WriteLine(arr.Length);
                for (int i = 0; i<arr.Length; i++)
                {
                    if (arr[i] == "(")
                    {
                        utility.AddString("(");
                    }
                    else if (arr[i] == ")")
                    {
                        utility.DeleteString("(");
                    }
                }
                utility.Isempty();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

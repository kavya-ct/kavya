// --------------------------------------------------------------------------------------------------------------------
// <copyright file=String.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kavya ct"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Functionalpgms
{
     /// <summary>
     /// 
     /// </summary>
    class String
    {
        Utility utility = new Utility();
        /// <summary>
        /// 
        /// </summary>
        public void Run() { 
            Console.WriteLine("please enter your name");
            string str1 = utility.CallStr();
            string str2 = "Hello   <<UserName>> How are You?";
            ////
            ///

            Console.WriteLine(str2.Replace(" <<UserName>>", str1));

        }
    }
}

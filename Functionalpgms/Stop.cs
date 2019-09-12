// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Stop.cs" company="Bridgelabz">
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
    /// Stop is class
    /// </summary>
    class Stop
    {
        /// <summary>
        /// Stops this instance.
        /// </summary>
        public void stop()
        {
            ////
            DateTime time = DateTime.Now;

            int h2 = time.Hour;
            int m2 = time.Minute;
            int s2 = time.Second;

            Console.WriteLine("press any keyto stop");
            string a = Console.ReadLine();
            if (a == "s")
            {
                DateTime date = DateTime.Now;
                int h1 = date.Hour;
                int m1 = date.Minute;
                int s1 = date.Second;
                Console.WriteLine("{0}:{1}:{2}", (h1 - h2), (m1 - m2), (s1 - s2));
            }

        }
    }
}

// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Flipcoin.cs" company="Bridgelabz">
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
    class Flipcoin
    {
        /// <summary>
        /// Flips this instance.
        /// </summary>
        public static void Flip()
        {
            double n, h_cnt = 0, t_cnt = 0;
            double head, tail;
            Console.WriteLine("enter no. of times you want to flip coin");
            n = int.Parse(Console.ReadLine());
            {
                ////
                ///
                for (int i = 0; i < n; i++)
                    {
                    Random random = new Random();
                    double value = random.NextDouble();
                    Console.WriteLine(value);
                    if (value < 0.5)
                        t_cnt++;
                    else
                        h_cnt++;
                   }

                head = (h_cnt / n) * 100;
                tail = (t_cnt / n) * 100;
                Console.WriteLine("Percentage of heads: " + head + "percentage");
                Console.WriteLine("Percentage of tails: " + tail + "percentage");
                Console.ReadLine();
            


            }

        }
    }
}

// --------------------------------------------------------------------------------------------------------------------
// <copyright file=VendingMachine.cs" company="Bridgelabz">
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
    /// VendingMachine is the class name
    /// </summary>
    public class VendingMachine
    {
        /// <summary>
        /// Minimums the notes.
        /// </summary>
        /// <param name="notes">The notes.</param>
        /// <param name="m">The m.</param>
        /// <param name="V">The v.</param>
        /// <returns></returns>
        public void Notes(int amount)
        {
            int[] notes = new int[] { 2000, 500, 20, 100, 50, 10, 5, 2, 1 };
            int[] noteCounter = new int[9];
            for (int i = 0; i < 9; i++)
            {
                if (amount >= notes[i])
                {
                    noteCounter[i] = amount / notes[i];
                    amount = amount - noteCounter[i] * notes[i];
                }
            }

            Console.WriteLine("Currency count");
            for (int i = 0; i < 9; i++)
            {
                if (noteCounter[i] != 0)
                {
                    Console.WriteLine(notes[i] + ":" + noteCounter[i]);
                }
            }
        }

        public void Amount()
        {
            Console.WriteLine("Enter the amount");
            int amount = Convert.ToInt32(Console.ReadLine());
            Notes(amount);
        }
    }
}
           


        
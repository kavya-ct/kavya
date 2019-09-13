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
        static int minNotes(int[] notes,int m,int V)
        {
            ////
            ///
            if (V == 0)
                return 0;
            int res = int.MaxValue;

            for(int i =0; i<m; i++)
                {
                if(notes[i] <= V)
                {
                    int sub_res = minNotes(notes, m, V - notes[i]);
                    if (sub_res != int.MaxValue && sub_res + 1 < res)
                        res = sub_res + 1;
                }
            }
            return res;

        }

        public  void Machine()
        {
            int[] notes = { 1, 2, 5, 10, 50, 100, 500, 1000 };
            int m = notes.Length;
            int V = 18;
            Console.Write("Minimum notes required is " +
                             minNotes(notes, m, V));
        }
    }
}

// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Nibbles.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kavya ct"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithmpgm
{/// <summary>
/// Nibbles is the class name
/// </summary>
   public class Nibbles
    {
        /// <summary>
        /// Swaps the nibbles.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <returns></returns>function for swapping
        static int swapNibbles(int x)
        {
            ////
            return ((x & 0x0f) << 4 | (x & 0xf0) >> 4);
        }

        public void Swap()
        {
            int x = 100;
            Console.Write(swapNibbles(x));
        }

    }
}

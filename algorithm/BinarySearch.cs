// --------------------------------------------------------------------------------------------------------------------
// <copyright file=BinarySearch.cs" company="Bridgelabz">
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
    /// BinarySearch is the classname
    /// </summary>
    public class BinarySearch
    {

        /// <summary>
        /// Binaries the search.
        /// </summary>
        /// <param name="arr">The arr.</param>
        /// <param name="x">The x.</param>
        /// <returns></returns>
        static int binarySearch(String[] arr, String x)
        {
            int l = 0, r = arr.Length - 1;
            while (l <= r)
            {
                int m = l + (r - l) / 2;

                int res = x.CompareTo(arr[m]);

                // Check if x is present at mid  
                if (res == 0)
                    return m;

                // If x greater, ignore left half  
                if (res > 0)
                    l = m + 1;

                // If x is smaller, ignore right half  
                else
                    r = m - 1;
            }

            return -1;
        }

        public void Binary()
        {
            String[] arr = { "country", "geeks", "ide", "practical" };
            String x = "ide";
            int result = binarySearch(arr, x);

            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at "
                                + "index " + result);
        }

    }
            

    }


// --------------------------------------------------------------------------------------------------------------------
// <copyright file=BubbleSort.cs" company="Bridgelabz">
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
    /// BubbleSort is the class name
    /// </summary>
    public class BubbleSort
    {
        /// <summary>
        /// Mysorts this instance.
        /// </summary>
        public void Mysort()
        {
            int[] arr = { 78, 55, 45, 98, 13 };
            int temp;

            for(int j = 0; j <= arr.Length-1; j++)
            {
                for(int i =0; i <= arr.Length-1; i++)
                {
                    if(arr[i] > arr[i+1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

            Console.WriteLine("sorted");
            foreach (int p in arr)
                Console.WriteLine(p + " ");
            Console.ReadLine();
        }




    }
}

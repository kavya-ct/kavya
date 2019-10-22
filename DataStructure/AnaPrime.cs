// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AnaPrime.cs" company="Bridgelabz">
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
    /// Anaprime is the class
    /// </summary>
    public class AnaPrime
    {
        /// <summary>
        /// instance
        /// </summary>
        public void Prime()
        {
            int k = 0;
            int[,] Prime = new int[10, 10000];
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = (i * 100) + 1; j <= (i + 1) * 100; j++)
                    {
                        int Count = 0;
                        for (int m = j; m > 0; m--)
                        {
                            if (j > 2)
                            {
                                if (j % m == 0)
                                {
                                    Count++;
                                }
                            }
                            if (Count == 2)
                            {
                                Prime[i, j] = j;
                            }
                        }
                    }
                    Console.WriteLine();
                }

                ////write prime numbers from the array
                Console.WriteLine("PrimeNumbers are :");
                int[] arr = new int[700];
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Prime numbers in between" + i * 100 + " +(i*100+100)");
                    ////Conditions to check the range
                    for (int j = i * 100; j < (i + 1) * 100; j++)
                    {
                        if (Prime[i, j] != 0)
                        {
                            Console.WriteLine(Prime[i, j] + " ");
                            int temp = Prime[i, j];
                            arr[k] = temp;
                            k++;
                        }
                    }
                    Console.WriteLine();
                }
                for (int x = 0; x < k; x++)
                {
                    for (int y = x + 1; y < k; y++)
                    {
                        string str1 = arr[x].ToString();
                        string str2 = arr[y].ToString();
                        if (str1.Length == str2.Length)
                        {
                            char[] char1 = str1.ToCharArray();
                            char[] char2 = str2.ToCharArray();
                            Array.Sort(char1);
                            Array.Sort(char2);
                            string NewWordD1 = new string(char1);
                            string NewWordD2 = new string(char2);
                            for (int n = 0; n < char1.Length; n++)
                            {
                                if (NewWordD1 == NewWordD2)
                                {
                                    Console.WriteLine("prime Anagram are" + str1 + " " + str2);

                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}

       
    


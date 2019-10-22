// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AnagramStack.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kavya ct"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace DataStructure
{
    /// <summary>
    /// AnagramStack is the class
    /// </summary>
    public class AnagramStack
    {
        /// <summary>
        /// Anagrams this instance.
        /// </summary>
        public void Stack()
        {
            ////try and catch are used to handle the exception
            try
            {
                int CountPrime = 0, CountPrime1 = 0;
                int[] array = new int[1000];

                for (int i = 0; i < 1000; i++)
                {
                    int Count = 0;
                    for (int j = i; j > 0; j--)
                    {
                        if (i > 2)
                        {
                            if (i % j == 0)
                            {
                                Count++;
                            }
                        }
                    }
                    if (Count == 2)
                    {
                        array[i] = i;
                        CountPrime++;
                    }
                }
                int[] anagram = new int[CountPrime];
                int[] anagram1 = new int[CountPrime1];
                for (int i = 0, j = 0; i < array.Length - 1; i++)
                {
                    if (array[i] != 0)
                    {
                        Console.Write(array[i] + " ");
                        anagram[j] = array[i];
                        j++;
                    }
                }
                int k = 0;

                for (int i = 0; i < anagram.Length - 1; i++)
                {
                    for (int j = i + 1; j < anagram.Length - 1; j++)
                    {
                        if (IsAnagram(anagram[i], anagram[j]))
                        {
                            Console.WriteLine(" " + anagram[i] + "," + anagram[j]);
                            if (anagram[i] != anagram[j])
                            {
                                anagram1[k] = anagram[j];
                                k++;
                                CountPrime1++;
                            }
                        }
                    }
                }
                Console.WriteLine("Anagram are:");
                for (int i = 0; i < CountPrime1; i++)
                {
                    Console.WriteLine(anagram1[i] + " ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

       

        public Boolean IsAnagram(int n1, int n2)
        {
            string str1 = n1.ToString();
            string str2 = n2.ToString();

            char[] ch1 = str1.ToCharArray();
            char[] ch2 = str2.ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);
            if (ch1.Length == ch2.Length)
            {
                int Count = 0;
                for (int i = 0; i < ch1.Length; i++)
                {
                    int j = 0;
                    if (ch1[i] == ch2[j])
                    {
                        Count++;
                    }
                }
                if (Count == ch1.Length)
                {
                    return true;
                }
                else
                    return false;
            }
            return false;
        }
    }

}


    



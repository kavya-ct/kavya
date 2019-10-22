// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Anagram.cs" company="Bridgelabz">
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
    /// Anagram is the class
    /// </summary>
    public class Anagram
    {
        /// <summary>
        /// Prints the anagrams.
        /// </summary>
        /// <param name="arr">The arr.</param>
        private static void printAnagrams(String[] arr)
        {
            Dictionary<String,
                  List<String>> map = new Dictionary<String,
                                                 List<String>>();

            // loop over all words  
            for (int i = 0; i < arr.Length; i++)
            {

                // convert to char array, sort and  
                // then re-convert to string  
                String word = arr[i];
                char[] letters = word.ToCharArray();
                Array.Sort(letters);
                String newWord = new String(letters);

                // calculate hashcode of string  
                // after sorting  
                if (map.ContainsKey(newWord))
                {
                    map[newWord].Add(word);
                }
                else
                {

                    // This is the first time we are  
                    // adding a word for a specific  
                    // hashcode  
                    List<String> words = new List<String>();
                    words.Add(word);
                    map.Add(newWord, words);
                }
            }

            // print all the values where size is > 1  
            // If you want to print non-anagrams,  
            // just print the values having size = 1  
            List<String> value = new List<String>();
            foreach (KeyValuePair<String,
                            List<String>> entry in map)
            {
                value.Add(entry.Key);
            }
            int k = 0;
            foreach (KeyValuePair<String,
                            List<String>> entry in map)
            {
                List<String> values = map[value[k++]];
                if (values.Count > 1)
                {
                    Console.Write("[");
                    int len = 1;
                    foreach (String s in values)
                    {
                        Console.Write(s);
                        if (len++ < values.Count)
                            Console.Write(", ");
                    }
                    Console.Write("]");
                }
            }
        }

        // Driver Code 
        public void Panagrams()
        {
            String[] arr = { "cat", "dog", "tac",
                                "god", "act" };
            printAnagrams(arr);
        }
    }
}


// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Searchtext.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kavya ct"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Algorithmpgm
{
    public class Searchtext
    {
        Utility utility = new Utility();
        public void TextFile()
        {
            try
            {
                string text = File.ReadAllText(@"C:\Users\Bridgelabz\Desktop\program.txt");
                string[] arr = text.Split(" ");
                foreach (string str in arr) ;
                Console.WriteLine(arr + " ");
                Console.WriteLine("Enter the element to Search");
                string key = Console.ReadLine();
                int first = 0, last = arr.Length - 1;
                utility.BinaryString(arr, first, last, key);
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
                 

            }

        }
    }


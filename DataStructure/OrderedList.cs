// --------------------------------------------------------------------------------------------------------------------
// <copyright file=OrderedList.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kavya ct"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace DataStructure
{



    /// <summary>
    /// OrderedList is the class name
    /// </summary>
    class OrderedList
    {
        Utility utility = new Utility();

        /// <summary>
        /// Orders this instance.
        /// </summary>
        public void Order()
        {
            ////try and catch are used to handle the Exception if occured
            try
            {
                ////Reading content from file
                string data = File.ReadAllText(@"C:\Users\Bridgelabz\Desktop\number.txt");
                ////split the contents according to the space
                string[] arr = data.Split(",");
                ////Sorting of array
                Array.Sort(arr);
                int[] numbers = new int[arr.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                    numbers[i] = int.Parse(arr[i]);
                }
                Console.WriteLine("Displayed list from linked list");

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(numbers[i]);
                    Utility utility = new Utility();
                    utility.AddIntegers(numbers[i]);
                }
                Console.WriteLine("Total length of the list: " + arr.Length);
                Console.WriteLine("enter the number to search");
                int search = Convert.ToInt32(Console.ReadLine());
                int r = utility.SearchIntegers(search);

                if (r == 1)
                {
                    Console.WriteLine("do you want to delete " + search + "number in the list press 1 for delete 0r 2 for ignore");
                    int n = Convert.ToInt32(Console.ReadLine());
                    if (n == 1)
                    {
                        utility.DeleteInteger(search);
                        utility.Display();
                    }
                    else


                        return;
                }
                else if (r == 0)
                {
                    Console.WriteLine("Do you want to add" + search + "number in the list press 1 for delete or 2 for ignore");
                    int a = Convert.ToInt32(Console.ReadLine());
                    if (a == 1)
                    {
                        utility.AddIntegers(search);
                        string output = search.ToString();
                        File.ReadAllText(@"C:\Users\Bridgelabz\Desktop\number.txt");
                        utility.Display();
                    }
                    return;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

          
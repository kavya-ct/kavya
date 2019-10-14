// --------------------------------------------------------------------------------------------------------------------
// <copyright file=InventaryData.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kavya ct"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace ObjectOrientedPrograms.Inventory
{
    /// <summary>
    /// InventaryData is the class
    /// </summary>
    public class InventaryData
    {
        /// <summary>
        /// Displays this instance.
        /// </summary>
        public void Display()
        {
            try
            {
                string path = (@"C:\Users\Bridgelabz\source\repos\ObjectOrientedPrograms\ObjectOrientedPrograms\Inventory\Data.json");
                ////serialization json object
                StreamReader read = new StreamReader(path);
                ////read all character
                var json = read.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<InventaryModel>>(json);
                Console.WriteLine("Name\tWeight\tRate(perkg)\tAmount");
                ////loop through array items
                foreach (var item in items)
                {
                    Console.WriteLine(item.Name + "\t" + item.Weight + "\t" + item.PricePerKg + "\t\t" + (item.Weight * item.PricePerKg));
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
    

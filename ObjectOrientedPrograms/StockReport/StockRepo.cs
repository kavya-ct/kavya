// --------------------------------------------------------------------------------------------------------------------
// <copyright file=InventaryData.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kavya ct"/>
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;


namespace ObjectOrientedPrograms.StockReport
{
    public class StockRepo
    {
        public void Report()
        {
            try
            {
                double totalstockcost = 0;
                string path = (@"C:\Users\Bridgelabz\source\repos\ObjectOrientedPrograms\ObjectOrientedPrograms\StockReport\StockReport.json");
                StreamReader read = new StreamReader(path);
                var json = read.ReadToEnd();
                StockModel[] items = JsonConvert.DeserializeObject<StockModel[]>(json);
                
                Console.WriteLine("Stock details for vehicles");

                Console.WriteLine("");
                for (int i = 0; i < items.Length; i++)
                {
                    Console.WriteLine("Stock Name: " + items[i].Stockname);
                    Console.WriteLine("Share person: " + items[i].Shareperson);
                    Console.WriteLine("Each Stock Cost: Rs." + items[i].Stockprice);
                    Console.WriteLine("Total cost for: " + items[i].Stockname + ":Rs." + (items[i].Shareperson * items[i].Stockprice));
                    
                    totalstockcost = totalstockcost + (items[i].Stockprice * items[i].Shareperson);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
       
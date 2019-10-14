using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace ObjectOrientedPrograms.CommercialData
{
    class WritetoFile
    {
        public static void DataWriteToFile(NewAccount newAccount)
        {
            string path = (@"C:\Users\Bridgelabz\source\repos\ObjectOrientedPrograms\ObjectOrientedPrograms\CommercialData\jsoncom.json");
            string jsonAddressBook = JsonConvert.SerializeObject(newAccount);
            System.IO.File.WriteAllText(path, jsonAddressBook);
        }
    }
}

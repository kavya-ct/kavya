using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace ObjectOrientedPrograms.CommercialData
{
    class JsonOperation
    {
        public static NewAccount JsonReadFile()
        {
            string path = (@"C:\Users\Bridgelabz\source\repos\ObjectOrientedPrograms\ObjectOrientedPrograms\CommercialData\jsoncom.json");
            if(File.Exists(path))
            {
                string jsonData = File.ReadAllText(path);
                NewAccount account = JsonConvert.DeserializeObject<NewAccount>(jsonData);
                return account;
            }
            else
            {
                Console.WriteLine("Specified path does not exist");
                return NewAccount();
            }
        }

        private static NewAccount NewAccount()
        {
            throw new NotImplementedException();
        }
    }
}

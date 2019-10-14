
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Office.Interop.Outlook;
using Newtonsoft.Json;

namespace ObjectOrientedPrograms.CommercialData
{
    class AccountOperation
    {
        public void DisplayStock()
        {
            NewAccount newAccount = JsonOperation.JsonReadFile();
            List<AccountModel> accountModels = newAccount.AccountList;
            double sum = 0;
            foreach (var account in accountModels)
            {
                Console.WriteLine("");
                Console.WriteLine("Account Name:" + account.AccountName + "\n Share Number" + account.ShareNumber + "\n Stock Price" + account.StockPrice);
                sum += account.StockPrice;
            }
            Console.WriteLine("Total value of accounts store in database Rs." + sum);
        }

        public void DisplayAccount()
        {
            string accountname;
            while (true)
            {
                Console.WriteLine("Enter the account name for which you want to buy");
                accountname = Console.ReadLine();
                if (InventoryUtility.ContainsCharacter(accountname))
                {
                    Console.WriteLine("no character allowed");
                    continue;
                }

                if (InventoryUtility.ContainsDigit(accountname))
                {
                    Console.WriteLine("no digit allowed");
                    continue;
                }

                if (InventoryUtility.CheckString(accountname))
                {
                    Console.WriteLine("you should specify name");
                    continue;
                }

                NewAccount newAccount = JsonOperation.JsonReadFile();
                List<AccountModel> accountModels = newAccount.AccountList;
                foreach (AccountModel name in accountModels)
                {
                    if (name.AccountName.Equals(accountname))
                    {
                        Console.WriteLine("Account Name:" + name.AccountName + "\n Share Number" + name.ShareNumber + "\n Stock Price" + name.StockPrice);

                    }
                }
                break;




            }
        }

        internal void Sell()
        {
            throw new NotImplementedException();
        }

        internal void Buy()
        {
            throw new NotImplementedException();
        }
    }
}
    

        
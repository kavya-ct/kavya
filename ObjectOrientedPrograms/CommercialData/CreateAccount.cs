using System;




namespace ObjectOrientedPrograms.CommercialData
{
    class CreateAccount
    {
        public void Create()
        {
            string accountname = null;
            int sharenumber = 0;
            double shareprice = 0;
            Console.WriteLine("enter name to create an account");
            accountname = Console.ReadLine();
            while(true)
            {
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
                    Console.WriteLine("you should specify number");
                    continue;
                }
                break;
            }
            sharenumber = 0;
            double stockprice = 0;
            AccountModel.CreateAccountObject(accountname, sharenumber, stockprice);
            Console.WriteLine("New account has been created with name" + accountname);

        }
    }
}

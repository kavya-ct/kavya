using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.CommercialData
{
    public class UserInput
    {
        public void Input()
        {
            try
            {
                char choice;
                int ch = 0;
                do
                {
                    Console.WriteLine("what you want");
                    Console.WriteLine("");
                    Console.WriteLine("1.Create new account");
                    Console.WriteLine("2.Add share and stock to account");
                    Console.WriteLine("3.Buy share of stock from account");
                    Console.WriteLine("4.Sell shares of stock from account");
                    Console.WriteLine("5.Display particular account details reports of shares and stocks");
                    Console.WriteLine("Exit");
                    Console.WriteLine("");
                    Console.WriteLine("Enter your choice to perform");
                    ch = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    switch (ch)
                    {
                        case 1:
                            CreateAccount create = new CreateAccount();
                            create.Create();
                            break;

                        case 2:
                            AccountOperation account = new AccountOperation();
                            account.DisplayAccount();
                            break;

                        case 3:
                            AccountOperation accountbuy = new AccountOperation();
                            accountbuy.Buy();
                            break;

                        case 4:
                            AccountOperation displayaccount = new AccountOperation();
                            displayaccount.DisplayAccount();
                            break;

                        case 5:
                            AccountOperation accountsell = new AccountOperation();
                            accountsell.Sell();
                            break;

                        


                    }

                    Console.WriteLine("Do you want to continue then press c");
                    choice = Convert.ToChar(Console.ReadLine());

                }
                while (choice == 'y');
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}











               
    


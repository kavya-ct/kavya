// --------------------------------------------------------------------------------------------------------------------
// <copyright file=BankingCashCounter.cs" company="Bridgelabz">
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
    /// BankingCashCounter is the class
    /// </summary>
    public class BankingCashCounter
    {
        Utility utility = new Utility();
        internal static int InitialAmount;
        /// <summary>
        /// Cashes the counter.
        /// </summary>
        public void CashCounter()
        {
            try
            {
                Char choice;
                int ch;
                do
                {
                    BankingCashCounter bankdata = new BankingCashCounter();
                    Console.WriteLine("What type of transaction do you received");
                    Console.WriteLine("");
                    Console.WriteLine("1.deposit cash");
                    Console.WriteLine("2.Withdrawl");
                    ch = Convert.ToInt32(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            utility.DepositCash(bankdata);
                            Console.WriteLine("update cash avialable on your bank after Deposits + Rs -" + InitialAmount);
                            break;

                        case 2:
                            utility.WithDrawlCash(bankdata);
                            Console.WriteLine("your available Balance after withdrawl = Rs -" + InitialAmount);
                            break;
                    }
                    Console.WriteLine("Do you want to continue then press y");
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

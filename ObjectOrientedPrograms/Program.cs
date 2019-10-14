using ObjectOrientedPrograms.CommercialData;
using ObjectOrientedPrograms.Inventory;
using ObjectOrientedPrograms.REGEX;
using ObjectOrientedPrograms.StockReport;
using System;

namespace ObjectOrientedPrograms
{
    class Program
    {
        static void Main(string[] args)

        {
            int choice;
            Console.WriteLine("1.InventaryData \n2.RegularExpression\n3.StockRepo");
            Console.WriteLine("4.DeckCardsOfJava\n5.AddressBook\n6.CommercialData");
            
            Console.WriteLine("Enter your choice!");
            choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    InventaryData invent = new InventaryData();
                    invent.Display();
                    break;

                case 2:
                    RegularExpression reg = new RegularExpression();
                    reg.Expression();
                    break;

                case 3:
                    StockRepo repo = new StockRepo();
                    repo.Report();
                    break;

                case 4:
                    DeckCardsOfJava java = new DeckCardsOfJava();
                    java.Deck();
                    break;

                case 5:
                    AddressBook book = new AddressBook();
                    book.Address();
                    
                    break;

                case 6:
                    CommercialData.UserInput accountOperation = new CommercialData.UserInput();
                    accountOperation.Input();
                    break;







                 

                
            }

        }
    }
}

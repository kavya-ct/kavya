using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Visitor
{
    class FruitStore
    {
        /// <summary>
        /// Fruits this instance.
        /// </summary>
        public static void Fruit()
        {
            
            string name;
            
            string PhoneNumber;
            
            string Address;
            
            string Email;
            



           ////User inputs

            Console.WriteLine("Welcome to Smartbuy Groceries <Press any key to continue>");
            
            Console.ReadKey();
            
            Console.Write("Enter your name: ");
            
            name = Console.ReadLine();
            
            Console.Write("Enter your PhoneNumber: ");
            
            PhoneNumber = Console.ReadLine();
            
            Console.Write("Enter your Address: ");
            
            Address = Console.ReadLine();
            
            Console.Write("Enter your E-mail: ");
            
            Email = Console.ReadLine();
            



            ////Display the Menu

            Console.WriteLine("\nFruit Menu \nOranges $1 \nApples $2 \ntomatoes $4 \nbananas $0.4 \npears $9 \ngrapes $3.8");
            
            Console.ReadKey();
            



        }

    }

}

        

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Visitor
{
    /// <summary>
    /// 
    /// </summary>
    class BookStore
    {
        /// <summary>
        /// Books this instance.
        /// </summary>
        public static void Book()
        {

            string name;

            string PhoneNumber;

            string Address;

            string Email;




            ////User inputs

            Console.WriteLine("Welcome to BookStore<Press any key to continue>");

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

            Console.WriteLine("\nBook Menu \nKannada $1 \nEnglish $2 \nHindi $4 \nTelugu $0.4 \nTamil $9 \nMalayalam $3.8");

            Console.ReadKey();




        }

    }

}

        

       
    



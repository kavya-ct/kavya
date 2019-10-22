using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SingletonLink
{
    /// <summary>
    /// 
    /// </summary>
    class BillPughSingleton
    {
        /// <summary>
        /// The counter
        /// </summary>
        private static int counter = 0;
        public static BillPughSingleton GetInstance { get; } = new BillPughSingleton();

        private BillPughSingleton()
        {
            counter++;
            Console.WriteLine("Counter value " + counter.ToString());
        }

        
        

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}

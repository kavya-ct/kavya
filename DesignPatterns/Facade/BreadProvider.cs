using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Facade
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="DesignPatterns.Facade.IBread" />
    public class BreadProvider : IBread
    {
        /// <summary>
        /// Gets the garlic bread.
        /// </summary>
        public void GetGarlicBread()
        {
            Console.WriteLine("Getting Garlic Bread.");
        }
        public void GetCheesyGarlicBread()
        {
            GetCheese();
            Console.WriteLine("Getting Cheesy Garlic Bread.");
        }
        private void GetCheese()
        {
            Console.WriteLine("Getting Cheese.");
        }
    }
}
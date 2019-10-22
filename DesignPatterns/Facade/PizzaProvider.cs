using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Facade
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="DesignPatterns.Facade.IPizza" />
    public class PizzaProvider : IPizza
    {
        /// <summary>
        /// Gets the non veg pizza.
        /// </summary>
        public void GetNonVegPizza()
        {
            GetNonVegToppings();
            Console.WriteLine("Getting Non Veg Pizza.");
        }
        public void GetVegPizza()
        {
            Console.WriteLine("Getting Veg Pizza.");
        }
        private void GetNonVegToppings()
        {
            Console.WriteLine("Getting Non Veg Pizza Toppings.");
        }
    }
}
    
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Facade
{
    /// <summary>
    /// 
    /// </summary>
    class FacadeDesignPattern
    {
        /// <summary>
        /// Addresses this instance.
        /// </summary>
        public static void Address ()
        {
            
            Console.WriteLine("\n------CLIENT ORDERS FOR PIZZA----\n");
            var facadeForClient = new RestaurantFacade();
            facadeForClient.GetNonVegPizza();
            facadeForClient.GetVegPizza();
            Console.WriteLine("\n-------CLIENT ORDERS FOR BREAD------\n");
            facadeForClient.GetGarlicBread();
            facadeForClient.GetCheesyGarlicBread();
            
        }
    }
}

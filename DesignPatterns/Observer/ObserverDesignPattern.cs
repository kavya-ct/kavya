using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer
{
    /// <summary>
    /// 
    /// </summary>
    class ObserverDesignPattern
    {
        /// <summary>
        /// Topics this instance.
        /// </summary>
        public static void Topic()
        {
            //// Create price watch for Beans and attach restaurants that buy carrots from suppliers.
            Beans beans = new Beans(0.83);
            beans.Attach(new Restaurant("George", 0.77));
            beans.Attach(new Restaurant("Noah", 0.74));
            beans.Attach(new Restaurant("Jacob", 0.75));

            //// Fluctuating beans prices will notify subscribing restaurants.
            beans.PricePerPound = 0.79;
            beans.PricePerPound = 0.76;
            beans.PricePerPound = 0.74;
            beans.PricePerPound = 0.81;

            Console.ReadKey();
        }
    }
}

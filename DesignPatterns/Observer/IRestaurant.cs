using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer
{
    /// <summary>
    /// 
    /// </summary>
    interface IRestaurant
    {
        /// <summary>
        /// Updates the specified veggies.
        /// </summary>
        /// <param name="veggies">The veggies.</param>
        void Update(Veggies veggies);
    }
}

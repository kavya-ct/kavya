using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Facade
{
    /// <summary>
    /// 
    /// </summary>
    public interface IPizza
    {
        /// <summary>
        /// Gets the veg pizza.
        /// </summary>
        void GetVegPizza();
        void GetNonVegPizza();
    }
}

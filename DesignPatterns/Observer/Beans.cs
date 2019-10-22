using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer
{


    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="DesignPatterns.Observer.Veggies" />
    class Beans : Veggies
        {
        /// <summary>
        /// Initializes a new instance of the <see cref="Beans"/> class.
        /// </summary>
        /// <param name="price">The price.</param>
        public Beans(double price) : base(price) { }
        }
    
}

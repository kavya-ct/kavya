using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Reflection
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="DesignPatterns.Reflection.Car" />
    internal class SportsCar : Car
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SportsCar"/> class.
        /// </summary>
        public SportsCar()
        {
            ////Change the default values 

            Color = "Green";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.Inventory
{
    /// <summary>
    /// 
    /// </summary>
    class InventaryModel
    {
        /// <summary>
        /// The name
        /// </summary>
        private string name;
        private double weight;
        private double priceperkg;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>
        /// The weight.
        /// </value>
        public double Weight { get; set; }

        /// <summary>
        /// Gets or sets the price per kg.
        /// </summary>
        /// <value>
        /// The price per kg.
        /// </value>
        public double PricePerKg { get; set; }
    }
}

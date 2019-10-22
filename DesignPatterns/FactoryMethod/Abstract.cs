using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethod
{

    /// <summary>
    /// 
    /// </summary>
    abstract class CreditCard
    {
        /// <summary>
        /// Gets the type of the card.
        /// </summary>
        /// <value>
        /// The type of the card.
        /// </value>
        public abstract string CardType { get; }
        public abstract int CreditLimit { get; set; }
        public abstract int AnnualCharge { get; set; }
    }
}


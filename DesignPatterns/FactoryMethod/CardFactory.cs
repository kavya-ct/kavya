using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethod
{
    /// <summary>
    /// 
    /// </summary>
    abstract class CardFactory
    {
        /// <summary>
        /// Gets the credit card.
        /// </summary>
        /// <returns></returns>
        public abstract CreditCard GetCreditCard();
    }
}
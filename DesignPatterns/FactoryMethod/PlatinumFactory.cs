using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethod
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="DesignPatterns.FactoryMethod.CardFactory" />
    class PlatinumFactory : CardFactory
    {
        /// <summary>
        /// The credit limit
        /// </summary>
        private int _creditLimit;
        private int _annualCharge;

        public PlatinumFactory(int creditLimit, int annualCharge)
        {
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }

        public override CreditCard GetCreditCard()
        {
            return new PlatinumCreditCard(_creditLimit, _annualCharge);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethod
{
    /// <summary>
    /// 
    /// </summary>
    namespace FactoryMethodDesignPatternInCSharp
    {
        /// <summary>
        /// 
        /// </summary>
        /// <seealso cref="DesignPatterns.FactoryMethod.CardFactory" />
        class TitaniumFactory : CardFactory
        {
            /// <summary>
            /// The credit limit
            /// </summary>
            private int _creditLimit;
            private int _annualCharge;

            public TitaniumFactory(int creditLimit, int annualCharge)
            {
                _creditLimit = creditLimit;
                _annualCharge = annualCharge;
            }

            public override CreditCard GetCreditCard()
            {
                return new TitaniumCreditCard(_creditLimit, _annualCharge);
            }
        }
    }
}

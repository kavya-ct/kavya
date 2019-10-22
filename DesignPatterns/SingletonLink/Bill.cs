using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SingletonLink
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class Bill<T>
    {
        private Func<BillPughSingleton> p;

        public Bill(Func<BillPughSingleton> p)
        {
            this.p = p;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SingletonLink
{
    /// <summary>
    /// 
    /// </summary>
    class LazyInitialization
    {
        /// <summary>
        /// The counter
        /// </summary>
        private static int counter = 0;
        private static readonly Lazy<LazyInitialization> instance = new Lazy<LazyInitialization>(() => new LazyInitialization());

        public static LazyInitialization GetInstance
        {
            get
            {
                return instance.Value;
            }
        }

        private LazyInitialization()
        {
            counter++;
            Console.WriteLine("Counter value" + counter.ToString());
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SingletonLink
{
    /// <summary>
    /// EagerInitialization is the class name
    /// </summary>
    public sealed class EagerInitialization
    {
        /// <summary>
        /// The counter
        /// </summary>
        private static int counter = 0;


        public static EagerInitialization GetInstance { get; } = new EagerInitialization();
        


        private EagerInitialization()
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

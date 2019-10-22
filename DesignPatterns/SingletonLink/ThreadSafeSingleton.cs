using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SingletonLink
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class ThreadSafeSingleton
    {
        /// <summary>
        /// The counter
        /// </summary>
        private static int counter = 0;
        private static readonly object obj = new object();
        private static ThreadSafeSingleton instance = null;


        public static ThreadSafeSingleton GetInstance
        {
            get
            {
                if(instance == null)
                {
                    lock(obj)
                    {
                        if (instance == null)
                            instance = new ThreadSafeSingleton();        
                        
                    }
                }

                return instance;
            }
        }

        private ThreadSafeSingleton()
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

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Mediator
{
    /// <summary>
    /// 
    /// </summary>
    abstract class Media

    {
        /// <summary>
        /// Sends the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="colleague">The colleague.</param>
        public abstract void Send(string message, Colleague colleague);

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Mediator
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="DesignPatterns.Mediator.Colleague" />
    class ConcreteColleague1 : Colleague

    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mediator"></param>
        

        public ConcreteColleague1(Media mediator) : base(mediator)
          
        {
        }

        public void Send(string message)
        {
            mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("Colleague1 gets message: " + message);
        }


    }
}
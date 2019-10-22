using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Mediator
{
    /// <summary>
    /// 
    /// </summary>
    abstract class Colleague

    {
        /// <summary>
        /// The mediator
        /// </summary>
        protected Media mediator;

        //// Constructor

        public Colleague(Media mediator)
        {
            this.mediator = mediator;
        }
    }
}
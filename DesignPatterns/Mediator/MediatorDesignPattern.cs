using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Mediator
{
    /// <summary>
    /// 
    /// </summary>
    class MediatorDesignPattern

    {
        /// <summary>

        /// Entry point into console application.

        /// </summary>

        public static void Focus()
        {
            ConcreteMediator m = new ConcreteMediator();

            ConcreteColleague1 c1 = new ConcreteColleague1(m);
            ConcreteColleague2 c2 = new ConcreteColleague2(m);

            m.Colleague1 = c1;
            m.Colleague2 = c2;

            c1.Send("Hello");
            c2.Send("How are you?");

            // Wait for user

            Console.ReadKey();
        }
    }
}



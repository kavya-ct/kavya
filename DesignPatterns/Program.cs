
using DesignPatterns.FactoryMethod;
using System;

namespace DesignPatterns
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("1.EagerInitialization\n2.FactoryMethod\n3.PrototypeDesignPattern");
            Console.WriteLine("4.AdapterDesignPattern\n5.FacadeDesignPattern\n6.ProxyDesignPattern");
            Console.WriteLine("7.ObserverDesignPattern\n8.Visitor\n9.MediatorDesignPattern");
            Console.WriteLine("10.DependencyInjection\n11.Reflection");
            


            Console.WriteLine("Enter your choice");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    SingletonLink.Singleton.SingletonOperation();
                    break;

                case 2:
                    FactoryMethod.ClientApplication.Computer();
                    
                    
                    break;

                case 3:
                    Prototype.DesignPattern.DesignOperation();
                    
                    break;

                case 4:
                    Adapter.AdapterDesignPattern.Work();
                    break;

                case 5:
                    Facade.FacadeDesignPattern.Address();
                    break;

                case 6:
                    Proxy.ProxyDesignPattern.Object();
                    break;

                case 7:
                    Observer.ObserverDesignPattern.Topic();
                    break;

                case 8:
                    Visitor.BookStore.Book();
                    Visitor.FruitStore.Fruit();
                    break;

                case 9:
                    Mediator.MediatorDesignPattern.Focus();
                    break;

                case 10:
                    DependencyInjection.Constructor.Server();
                    break;

                case 11:
                    Reflection.TypeProperties.Money();
                    break;

                   
        
                        












                default:
                    Console.WriteLine("Invalid Choice");
                    break;

            }
        }
    }
}

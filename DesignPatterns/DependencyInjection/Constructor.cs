using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DependencyInjection
{
    /// <summary>
    /// 
    /// </summary>
    class Constructor
    {

        /// <summary>
        /// Servers this instance.
        /// </summary>
        public static void Server()
            {
                client cn = new client();
                cn.run(new servic());
                Console.ReadKey();
            }
        }
    }



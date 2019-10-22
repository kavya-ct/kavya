using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Adapter
{
    /// <summary>
    /// 
    /// </summary>
    class AdapterDesignPattern
    {
        /// <summary>
        /// Works this instance.
        /// </summary>
        public static void Work()
            {
                //// Non-adapted chemical compound

                Compound unknown = new Compound("Unknown");
                unknown.Display();

                //// Adapted chemical compounds

                Compound water = new RichCompound("Water");
                water.Display();

                Compound benzene = new RichCompound("Benzene");
                benzene.Display();

                Compound ethanol = new RichCompound("Ethanol");
                ethanol.Display();

                //// Wait for user

                Console.ReadKey();
            }
        }

    }


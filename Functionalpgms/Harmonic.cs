﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Harmonic.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kavya ct"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Functionalpgms
{
    /// <summary>
    /// 
    /// </summary>
    class Harmonic
    {
        /// <summary>
        /// Harmons this instance.
        /// </summary>
        public static void Harmon()
        {    
           
            

            double N;
            Harmonic h = new Harmonic();
            Console.WriteLine("enter harmonic value:");
            N = int.Parse(Console.ReadLine());
            ////
            ///
            if (N != 0) 
            {
                double r = 0.0;
                for(double i = 1; i<=N; i++)
                {
                    r = r + (1 / i);
                }
                Console.WriteLine("the Nth Harmonic number will be:" + r);
                Console.ReadLine();
                
            }

        }
    }
}

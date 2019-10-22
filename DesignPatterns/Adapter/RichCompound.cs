﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Adapter
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="DesignPatterns.Adapter.Compound" />
    class RichCompound : Compound

    {
        /// <summary>
        /// The bank
        /// </summary>
        private ChemicalDataBank _bank;

        // Constructor

        public RichCompound(string name)
          : base(name)
        {
        }

        public override void Display()
        {
            //// The Adaptee

            _bank = new ChemicalDataBank();

            _boilingPoint = _bank.GetCriticalPoint(_chemical, "B");
            _meltingPoint = _bank.GetCriticalPoint(_chemical, "M");
            _molecularWeight = _bank.GetMolecularWeight(_chemical);
            _molecularFormula = _bank.GetMolecularStructure(_chemical);

            base.Display();
            Console.WriteLine(" Formula: {0}", _molecularFormula);
            Console.WriteLine(" Weight : {0}", _molecularWeight);
            Console.WriteLine(" Melting Pt: {0}", _meltingPoint);
            Console.WriteLine(" Boiling Pt: {0}", _boilingPoint);
        }
    }
}
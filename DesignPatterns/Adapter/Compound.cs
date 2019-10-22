using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Adapter
{
    /// <summary>
    /// 
    /// </summary>
    class Compound
    {
        /// <summary>
        /// The chemical
        /// </summary>
        protected string _chemical;
        protected float _boilingPoint;
        protected float _meltingPoint;
        protected double _molecularWeight;
        protected string _molecularFormula;

        //// Constructor

        public Compound(string chemical)
        {
            this._chemical = chemical;
        }

        public virtual void Display()
        {
            Console.WriteLine("\nCompound: {0} ------ ", _chemical);
        }
    }
}


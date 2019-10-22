using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Prototype
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="DesignPatterns.Prototype.IEmployee" />
    public class TemporaryEmployee : IEmployee
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }
        public int Age { get; set; }
        public string EmploymentType { get; set; }

        ////Implement shallow cloning method
        public IEmployee Clone()
        {
            //// Shallow Copy 
            return this.MemberwiseClone() as IEmployee;

            
            
        }
    }


}


//-------------------------------------------------------------------------------------------------------------------
// <copyright file=Employee.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kavya"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Model
{
    public class Employee

    {
        [Key]
        [Required(ErrorMessage = "Id is required.")]

        public string id
        {
            get; set;
        }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [Display(Name = "Name")]
        public string name
        {
            get; set;
        }
        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        [Display(Name = "City")]
        public string city
        {
            get; set;
        }
        /// <summary>
        /// Gets or sets the designation.
        /// </summary>
        /// <value>
        /// The designation.
        /// </value>
        [Display(Name = "Designation")]
        public string designation
        {
            get; set;
        }
      
    }
}



using EmployeeManagementSystem.Model;
//-------------------------------------------------------------------------------------------------------------------
// <copyright file=EmployeeManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kavya"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Manager
{
    public interface IEmployeeManager
    {
        /// <summary>
        /// Adds the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="city">The city.</param>
        /// <param name="designation">The designation.</param>
        /// <returns></returns>
        string Add(string id, string name, string city, string designation);
        string Update(string id, string name, string city, string designation);
        string Delete(string id);
        string LoginEmployee(string id, string city);
        IEnumerable<Employee> Get();
    }
}
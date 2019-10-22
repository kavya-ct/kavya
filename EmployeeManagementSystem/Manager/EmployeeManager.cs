
//-------------------------------------------------------------------------------------------------------------------
// <copyright file=EmployeeManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kavya"/>
// --------------------------------------------------------------------------------------------------------------------

using EmployeeManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Manager
{
    /// <summary>
    /// EmployeeManager is a class which interface with IEmployeemanager.
    /// </summary>
    /// <seealso cref="EmployementManagementSystem.Manager.IEmployeeManager" />
    public class EmployeeManager : IEmployeeManager
    {
        private readonly IEmployeeManagement employeeRepositry;
        public EmployeeManager()
        {
        }
        public EmployeeManager(IEmployeeManagement employeeManagement)
        {
            employeeRepositry = employeeManagement;
        }
        Employee employee = new Employee();
        /// <summary>
        /// Adds the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="city">The city.</param>
        /// <param name="designation">The designation.</param>
        /// <returns></returns>
        public string Add(string id, string name, string city, string designation)
        {
            employee.id = id;
            employee.name = name;
            employee.city = city;
            employee.designation = designation;
            employeeRepositry.AddEmployee(employee.id, employee.name, employee.city, employee.designation);
            return "Added Successfully";
        }
        /// <summary>
        /// Updates the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="city">The city.</param>
        /// <param name="designation">The designation.</param>
        /// <returns></returns>
        public string Update(string id, string name, string city, string designation)
        {
            employee.id = id;
            employee.name = name;
            employee.city = city;
            employee.designation = designation;
            try
            {
                bool result = employeeRepositry.UpdateEmployee(employee.id, employee.name, employee.city, employee.designation);
                if (result)
                {
                    return "update Successfully";
                }
                else
                    return "failed";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public string Delete(string id)
        {
            employee.id = id;
            employeeRepositry.DeleteEmployee(employee.id);

            return "Deleted Successfully";
        }
        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Employee> Get()
        {
            return (employeeRepositry.GetEmployees().AsEnumerable());
        }


        public string LoginEmployee(string id, string city)
        {

            bool result = employeeRepositry.LoginEmployee(id, city);
            if (result)
            {
                return "Login Successfully";
            }
            else
                return "failed";
        }
    }
}





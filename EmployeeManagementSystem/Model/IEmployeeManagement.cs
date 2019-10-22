//-------------------------------------------------------------------------------------------------------------------
// <copyright file=interface.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kavya"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Model
{
    
        public interface IEmployeeManagement
        {
            List<Employee> GetEmployees();
            bool AddEmployee(String id, String name, String city, String Designation);
            bool UpdateEmployee(String id, String name, String city, String Designation);
            bool DeleteEmployee(String id);
        bool LoginEmployee(string id, string city);
       // void DeleteEmployee(string id);
    }
}




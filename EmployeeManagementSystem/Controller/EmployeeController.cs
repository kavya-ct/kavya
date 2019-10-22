//-------------------------------------------------------------------------------------------------------------------
// <copyright file=EmployeeController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kavya"/>
// --------------------------------------------------------------------------------------------------------------------

using EmployeeManagementSystem.Manager;
using EmployeeManagementSystem.Model;
using EmployeeManagementSystem.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Controller
{       

    //[Route("api/[controller]")]
    //[ApiController]
    public class EmployeeController : ControllerBase
    {        
        EmployeeRepository empRepo = new EmployeeRepository();
        private readonly IEmployeeManager employeeManager;
        public EmployeeController(IEmployeeManager employee)
        {
            employeeManager = employee;
        }
        [HttpGet]
        [Route("get")]
        public IActionResult ListOfEmployees()
        {
            try
            {
                return Ok(employeeManager.Get());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("add")]
        public IActionResult AddEmployee(Employee employee)
        {
            try
            {

                var result = employeeManager.Add(employee.id, employee.name, employee.city, employee.designation);
                return Ok(new { result });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpPut]
        [Route("Update")]
        public IActionResult UpdateEmployee(string id, string name, string city, string designation)
        {
            try
            {
                var result = employeeManager.Update(id, name, city, designation);
                return Ok(new { result });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        [Route("Delete")]
        public IActionResult DeleteEmployee(string id)
        {
            try
            {
                var result = employeeManager.Delete(id);
                return Ok(new { result });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("Login")]
        public IActionResult LoginEmployee(string id, string name)
        {
            try
            {
                var result = employeeManager.LoginEmployee(id, name);
                return Ok(new { result });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }


}
















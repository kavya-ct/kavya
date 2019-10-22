//-------------------------------------------------------------------------------------------------------------------
// <copyright file=EmployeeRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kavya"/>
// --------------------------------------------------------------------------------------------------------------------

using EmployeeManagementSystem.Model;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Repository
{
    public class EmployeeRepository : IEmployeeManagement
    {
        /// <summary>
        /// The connect
        /// </summary>
        private SqlConnection connect = null;
        private readonly IConfiguration configurations;
        string Connectstr = null;
        public EmployeeRepository()
        {

        }
        public EmployeeRepository(IConfiguration configuration)
        {
            configurations = configuration;
        }
        //// To Handle connection related activities
        public void Connection()
        {
            try
            {
                Connectstr = configurations.GetSection("ConnectionString").GetSection("UserDBConncetion").Value;
                connect = new SqlConnection(Connectstr);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="city">The city.</param>
        /// <param name="designation">The designation.</param>
        /// <returns></returns>
        public bool AddEmployee(string id, string name, string city, string designation)
        {
            Connection();
            SqlCommand command = new SqlCommand("AddNewEmpDetails", connect);
            Employee employee = new Employee();
            employee.id = id;
            employee.name = name;
            employee.city = city;
            employee.designation = designation;
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Id", employee.id);
            command.Parameters.AddWithValue("@Name", employee.name);
            command.Parameters.AddWithValue("@City", employee.city);
            command.Parameters.AddWithValue("@Designation", employee.designation);
            connect.Open();
            int i = command.ExecuteNonQuery();
            if (i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Employee> GetEmployees()
        {
            Connection();
            List<Employee> employees = new List<Employee>();
            SqlCommand command = new SqlCommand("GetEmployees", connect);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            connect.Open();
            adapter.Fill(dataTable);
            connect.Close();
            employees = (from DataRow data in dataTable.Rows
                         select new Employee()
                         {
                             id = Convert.ToString(data["id"]),
                             name = Convert.ToString(data["name"]),
                             city = Convert.ToString(data["city"]),
                             designation = Convert.ToString(data["designation"]),

                         }).ToList();
            return employees;

        }

        public bool UpdateEmployee(string id, string name, string city, string Designation)
        {
            Connection();
            SqlCommand command = new SqlCommand("UpdateEmpDetails", connect);
            Employee employee = new Employee();
            employee.id = id;
            employee.name = name;
            employee.city = city;
            employee.designation = Designation;
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@EmpId", employee.id);
            command.Parameters.AddWithValue("@Name", employee.name);
            command.Parameters.AddWithValue("@City", employee.city);
            command.Parameters.AddWithValue("@Designation", employee.designation);
            connect.Open();
            int i = command.ExecuteNonQuery();
            if (i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteEmployee(string id)
        {
            Connection();
            SqlCommand command = new SqlCommand("DeleteEmployee", connect);
            Employee employee = new Employee();
            employee.id = id;

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", employee.id);

            connect.Open();
            int i = command.ExecuteNonQuery();
            if (i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool LoginEmployee(string id, string name)
        {
            Connection();
            SqlCommand command = new SqlCommand("loginemployee", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@name", name);
            connect.Open();
            DataSet dataSet = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dataSet);
            connect.Close();

            bool LoginEmployeeSuccessfully = ((dataSet.Tables.Count > 0) && (dataSet.Tables[0].Rows.Count > 0));

            if (LoginEmployeeSuccessfully && id != "" && name != " ")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}

        
    





  
    



using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Prototype
{
    /// <summary>
    /// 
    /// </summary>
    class DesignPattern
    {

        /// <summary>
        /// Designs the operation.
        /// </summary>
        public static void DesignOperation()
            {
                PermanentEmployee permanentEmployee = new PermanentEmployee();
                permanentEmployee.Name = "Sam";
                permanentEmployee.Age = 25;
                permanentEmployee.EmploymentType = "Permanent";

                //// clone permanent employee object with Clone method
                //// If you will not set the new value for any field the it will take the default value from original object

                PermanentEmployee permanentEmployeeClone = (PermanentEmployee)permanentEmployee.Clone();
                permanentEmployeeClone.Name = "Tom";
                permanentEmployeeClone.Age = 30;

                Console.WriteLine("Permanent Employee Details");
                Console.WriteLine("Name: {0}; Age: {1}; Employment Type: {2}", permanentEmployee.Name, permanentEmployee.Age, permanentEmployee.EmploymentType);

                Console.WriteLine("Cloned Permanent Employee Details");
                Console.WriteLine("Name: {0}; Age: {1}; Employment Type: {2}", permanentEmployeeClone.Name, permanentEmployeeClone.Age, permanentEmployeeClone.EmploymentType);

                //// you can perform the same operation for Temporary Employee

                Console.ReadLine();
            }
        }
    }



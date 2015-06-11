using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedAssist.Model;
using MedAssist.DAL;

namespace MedAssist.Controller
{
    /// <summary>
    /// Coordinates the actions between the EmployeeDAL and Views
    /// </summary>
    class EmployeeController
    {
        EmployeeDAL empDAL = new EmployeeDAL();
        public EmployeeController() { }

        /// <summary>
        /// Gets a list of Doctor Employees
        /// </summary>
        /// <returns>The list of Doctor Employees</returns>
        public List<Employee> GetListOfDoctorEmployees()
        {
            return empDAL.GetListOfDoctorEmployees();
        }

        /// <summary>
        /// Gets an employee by their ID
        /// </summary>
        /// <param name="id">EmployeeID</param>
        /// <returns>Employee</returns>
        public static Employee GetEmployeeByID(int id)
        {
            return EmployeeDAL.GetEmployeeByID(id);
        }

        /// <summary>
        /// Returns if employee is a Doctor. 
        /// </summary>
        /// <param name="employee">Employee's ID</param>
        /// <returns>True if Doctor, false if not</returns>
        public static bool isEmployeeDoctor(int employeeID)
        {
            return EmployeeDAL.isEmployeeDoctor(employeeID);
        }

        /// <summary>
        /// Returns if Employee is a Nurse. 
        /// </summary>
        /// <param name="employee">Employee's ID</param>
        /// <returns>True if Nurse, False if not</returns>
        public static bool isEmployeeNurse(int employeeID)
        {
            return EmployeeDAL.isEmployeeNurse(employeeID);
        }

        /// <summary>
        /// Returns if Employee is an Admin. 
        /// </summary>
        /// <param name="employee">Employee's ID</param>
        /// <returns>True if Admin, False if not</returns>
        public static bool isEmployeeAdmin(int employeeID)
        {
            return EmployeeDAL.isEmployeeAdmin(employeeID);
        }

        public static bool UpdateEmployee(Employee oldEmployee, Employee employee) 
        {
            return EmployeeDAL.UpdateEmployee(oldEmployee, employee);
        }
    }
}

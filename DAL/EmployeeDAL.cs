using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedAssist.Model;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MedAssist.DAL
{
    /// <summary>
    /// Used to interact with the Employee Table of the database
    /// </summary>
    class EmployeeDAL
    {
        public EmployeeDAL() { }

        /// <summary>
        /// Gets a list of Employees that are doctors and returns that list.
        /// </summary>
        /// <returns>Employee List of Doctor Employees</returns>
        public List<Employee> GetListOfDoctorEmployees()
        {
            List<Employee> employeeList = new List<Employee>();
            SqlConnection connection = MedassistDB.GetConnection();
            String selectStatement = "SELECT EmployeeID, SSN, FirstName, MInit, LastName, DOB, Gender, " +
	            "StreetAddress1, StreetAddress2, Phone, City, State, ZipCode, Inactive " +
                "FROM Employees e JOIN Doctors d ON e.EmployeeID = d.DoctorID " +
                "WHERE Inactive = 0";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            SqlDataReader reader = null;
            try
            {
                connection.Open();
                reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Employee employee = new Employee();
                    employee.EmployeeID = (int)reader["EmployeeID"];
                    employee.SSN = reader["SSN"].ToString();
                    employee.FirstName = reader["FirstName"].ToString();
                    employee.MInit = reader["MInit"].ToString();
                    employee.LastName = reader["LastName"].ToString();
                    employee.DOB = (DateTime)reader["DOB"];
                    employee.Gender = reader["Gender"].ToString()[0];
                    employee.StreetAddr1 = reader["StreetAddress1"].ToString();
                    employee.StreetAddr2 = reader["StreetAddress2"].ToString();
                    employee.Phone = reader["SSN"].ToString();
                    employee.City = reader["City"].ToString();
                    employee.State = reader["State"].ToString();
                    employee.ZipCode = reader["ZipCode"].ToString();
                    employee.Inactive = Convert.ToBoolean(reader["Inactive"]);
                    employeeList.Add(employee);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
                if (reader != null)
                    reader.Close();
            }
            return employeeList;
        }

        /// <summary>
        /// Gets the employees information using the EmployeeID
        /// </summary>
        /// <param name="employeeID">EmployeeID</param>
        /// <returns>Employee</returns>
        public static Employee GetEmployeeByID(int employeeID)
        {
            Employee employee = new Employee();
            SqlConnection connection = MedassistDB.GetConnection();
            string selectStatement =

                   "SELECT EmployeeID, FirstName, MInit, DOB, Gender, SSN, LastName, StreetAddress1, StreetAddress2, City, State, ZipCode, Phone, Inactive " +
                   "FROM Employees " +
                   "WHERE EmployeeID = @EmployeeID";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@EmployeeID", employeeID);
            SqlDataReader reader = null;
            try
            {
                connection.Open();
                reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    employee.EmployeeID = (int)reader["EmployeeID"];
                    employee.FirstName = reader["FirstName"].ToString();
                    employee.LastName = reader["LastName"].ToString();
                    employee.MInit = reader["Minit"].ToString();
                    employee.DOB = (DateTime)reader["DOB"];
                    employee.Gender = Convert.ToChar(reader["Gender"]);
                    employee.SSN = reader["SSN"].ToString();
                    employee.StreetAddr1 = reader["StreetAddress1"].ToString();
                    employee.StreetAddr2 = reader["StreetAddress2"].ToString();
                    employee.City = reader["City"].ToString();
                    employee.State = reader["State"].ToString();
                    employee.ZipCode = reader["ZipCode"].ToString();
                    employee.Phone = reader["Phone"].ToString();
                    employee.Inactive = (bool)reader["Inactive"];
                }
                else
                {
                    employee = null;
                } 
                
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
                if (reader != null)
                    reader.Close();
            }
            return employee;
        }

        /// <summary>
        /// Returns if employee is a Doctor. 
        /// </summary>
        /// <param name="employee">Employee's ID</param>
        /// <returns>True if Doctor, false if not</returns>
        public static bool isEmployeeDoctor(int employeeID)
        {
            Employee employee = new Employee();
            bool isDoctor = false;
            SqlConnection connection = MedassistDB.GetConnection();
            string selectStatement1 =
                   "SELECT DoctorID " +
                   "FROM Employees e JOIN Doctors d ON e.EmployeeID = d.DoctorID " +
                   "WHERE EmployeeID = @EmployeeID";
            SqlCommand selectCommand1 = new SqlCommand(selectStatement1, connection);
            selectCommand1.Parameters.AddWithValue("@EmployeeID", employeeID);
            SqlDataReader reader = null;
            try
            {
                connection.Open();
                reader = selectCommand1.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    employee.EmployeeID = (int)reader["DoctorID"];
                    isDoctor = true;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
                if (reader != null)
                    reader.Close();
            }
                return isDoctor;
        }

        /// <summary>
        /// Returns if Employee is a Nurse. 
        /// </summary>
        /// <param name="employee">Employee's ID</param>
        /// <returns>True if Nurse, False if not</returns>
        public static bool isEmployeeNurse(int employeeID)
        {
            Employee employee = new Employee();
            bool isNurse = false;
            SqlConnection connection = MedassistDB.GetConnection();
            string selectStatement1 =
                   "SELECT NurseID " +
                   "FROM Employees e JOIN Nurses n ON e.EmployeeID = n.NurseID " +
                   "WHERE EmployeeID = @EmployeeID";
            SqlCommand selectCommand1 = new SqlCommand(selectStatement1, connection);
            selectCommand1.Parameters.AddWithValue("@EmployeeID", employeeID);
            SqlDataReader reader = null;
            try
            {
                connection.Open();
                reader = selectCommand1.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    employee.EmployeeID = (int)reader["NurseID"];
                    isNurse = true;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
                if (reader != null)
                    reader.Close();
            }
            return isNurse;
        }

        /// <summary>
        /// Returns if Employee is an Admin. 
        /// </summary>
        /// <param name="employee">Employee's ID</param>
        /// <returns>True if Admin, False if not</returns>
        public static bool isEmployeeAdmin(int employeeID)
        {
            Employee employee = new Employee();
            bool isAdmin = false;
            SqlConnection connection = MedassistDB.GetConnection();
            string selectStatement1 =
                   "SELECT AdminID " +
                   "FROM Employees e JOIN Administrators a ON e.EmployeeID = a.AdminID " +
                   "WHERE EmployeeID = @EmployeeID";
            SqlCommand selectCommand1 = new SqlCommand(selectStatement1, connection);
            selectCommand1.Parameters.AddWithValue("@EmployeeID", employeeID);
            SqlDataReader reader = null;
            try
            {
                connection.Open();
                reader = selectCommand1.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    employee.EmployeeID = (int)reader["AdminID"];
                    isAdmin = true;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
                if (reader != null)
                    reader.Close();
            }
            return isAdmin;
        }

        /// <summary>
        /// Adds an Employee
        /// </summary>
        /// <param name="employee">The Employee</param>
        /// <returns>The EmployeeID</returns>
        public static int AddEmployee(Employee employee)
        {
            SqlConnection connection = MedassistDB.GetConnection();
            string insertStatement =
                "Insert Employees " +
                "(FirstName, MInit, LastName, SSN, StreetAddress1, StreetAddress2, City, State, ZipCode, Phone, DOB, Gender) " +
                "Values (@FirstName, @MInit, @LastName, @SSN, @StreetAddress1, @StreetAddress2, @City, @State, @ZipCode, @Phone, @DOB, @Gender)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@SSN", employee.SSN);
            insertCommand.Parameters.AddWithValue("@FirstName", employee.FirstName);
            insertCommand.Parameters.AddWithValue("@LastName", employee.LastName);
            insertCommand.Parameters.AddWithValue("@MInit", employee.MInit);
            insertCommand.Parameters.AddWithValue("@StreetAddress1", employee.StreetAddr1);
            insertCommand.Parameters.AddWithValue("@StreetAddress2", employee.StreetAddr2);
            insertCommand.Parameters.AddWithValue("@City", employee.City);
            insertCommand.Parameters.AddWithValue("@State", employee.State);
            insertCommand.Parameters.AddWithValue("@ZipCode", employee.ZipCode);
            insertCommand.Parameters.AddWithValue("@Phone", employee.Phone);
            insertCommand.Parameters.AddWithValue("@DOB", employee.DOB);
            insertCommand.Parameters.AddWithValue("@Gender", employee.Gender);
            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                string selectStatement =
                    "Select Ident_Current('Employees') FROM Employees";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                int employeeID = Convert.ToInt32(selectCommand.ExecuteScalar());
                switch (employee.Type)
                {
                    case Employee.EmployeeType.Doctor:
                        const string doctorInsert = "insert into doctors (DoctorID) values (@DoctorID)";
                        SqlCommand doctorCommand = new SqlCommand(doctorInsert, connection);
                        doctorCommand.Parameters.AddWithValue("@DoctorID", employeeID);
                        doctorCommand.ExecuteNonQuery();
                        break;
                    case Employee.EmployeeType.Nurse:
                        const string nurseInsert = "insert into nurses (NurseID, UserName) values (@NurseID, @UserName)";
                        SqlCommand nurseCommand = new SqlCommand(nurseInsert, connection);
                        nurseCommand.Parameters.AddWithValue("@NurseID", employeeID);
                        nurseCommand.Parameters.AddWithValue("@UserName", employee.UserName);
                        nurseCommand.ExecuteNonQuery();
                        break;
                    case Employee.EmployeeType.Admin:
                        const string adminInsert = "insert into Administrators (AdminID, UserName) values (@AdminID, @UserName)";
                        SqlCommand adminCommand = new SqlCommand(adminInsert, connection);
                        adminCommand.Parameters.AddWithValue("@AdminID", employeeID);
                        adminCommand.Parameters.AddWithValue("@UserName", employee.UserName);
                        adminCommand.ExecuteNonQuery();
                        break;
                }

                return employeeID;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

       

        /// <summary>
        /// Updates the Employee
        /// </summary>
        /// <param name="oldEmployee">The old Employee</param>
        /// <param name="newEmployee">The new Employee</param>
        /// <returns>True if successful</returns>
        public static bool UpdateEmployee(Employee oldEmployee, Employee newEmployee)
        {
            SqlConnection connection = MedassistDB.GetConnection();
            string updateStatement =
                "UPDATE Employees SET " +
                "FirstName = @NewFirstName, " +
                "LastName = @NewLastName, " +
                "MInit = @NewMInit, " +
                "DOB = @DOB, " +
                "StreetAddress1 = @NewStreetAddress1, " +
                "StreetAddress2 = @NewStreetAddress2, " +
                "Phone = @NewPhone, " +
                "City = @NewCity, " +
                "State = @NewState, " +
                "ZipCode = @NewZipCode, " +
                "Inactive = @Inactive " +
                "WHERE EmployeeID = @OldEmployeeID";
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@NewFirstName", newEmployee.FirstName);
            updateCommand.Parameters.AddWithValue("@NewLastName", newEmployee.LastName);
            updateCommand.Parameters.AddWithValue("@DOB", newEmployee.DOB);
            updateCommand.Parameters.AddWithValue("@NewMInit", newEmployee.MInit);
            updateCommand.Parameters.AddWithValue("@NewStreetAddress1", newEmployee.StreetAddr1);
            updateCommand.Parameters.AddWithValue("@NewStreetAddress2", newEmployee.StreetAddr2);
            updateCommand.Parameters.AddWithValue("@NewPhone", newEmployee.Phone);
            updateCommand.Parameters.AddWithValue("@NewCity", newEmployee.City);
            updateCommand.Parameters.AddWithValue("@NewState", newEmployee.State);
            updateCommand.Parameters.AddWithValue("@NewZipCode", newEmployee.ZipCode);
            updateCommand.Parameters.AddWithValue("@Inactive", newEmployee.Inactive);
            updateCommand.Parameters.AddWithValue("@OldEmployeeID", oldEmployee.EmployeeID);
            try
            {
                connection.Open();
                int count = updateCommand.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MedAssist.Model;

namespace MedAssist.DAL
{
    class UserSecurityDAL
    {
        /// <summary>
        /// Updates password
        /// </summary>
        /// <param name="oldUser"></param>
        /// <param name="newUser"></param>
        /// <returns></returns>
        public static bool UpdatePassword(UserSecurity oldUser, UserSecurity newUser)
        {
            string updateCommand = "UPDATE UserSecurity SET " +
                "Password = @newPassword " +
                "WHERE UserName = @oldUserName AND " +
                "Password = @oldPassword";
            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.Open();
                    using (SqlCommand cmnd = new SqlCommand(updateCommand, connection))
                    {
                        cmnd.Parameters.AddWithValue("@newPassword", newUser.Password);
                        cmnd.Parameters.AddWithValue("@oldUserName", oldUser.UserName);
                        cmnd.Parameters.AddWithValue("@oldPassword", oldUser.Password);
                        int count = cmnd.ExecuteNonQuery();
                        if (count > 0)
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
            catch (SqlException ex)
            {
                throw ex;
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// Add New Employee to security table
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public static string AddEmployee(Employee employee)
        {
            string userName;
            SqlConnection connection = MedassistDB.GetConnection();
            string insertStatement =
                "Insert UserSecurity " +
                "(UserName) " +
                "Values (@UserName)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@UserName", employee.UserName);
            userName = employee.UserName;
            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                string selectStatement =
                    "Select Ident_Current('UserName') FROM UserSecurity";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return userName;
        }
    }
}



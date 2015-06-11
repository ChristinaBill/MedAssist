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
    class AdminDAL
    {
        /// <summary>
        /// Interacts with usersecurity on behalf of Administators
        /// </summary>
        /// <param name="userName">the username</param>
        /// <param name="password">the password</param>
        /// <returns>An Administrator</returns>
        public static Administrator GetAdmin(string userName, string password)
        {
            Administrator admin = null;
            String selectStatement = " SELECT a.UserName, u.Password, a.AdminID " +
                " FROM Administrators a JOIN UserSecurity u ON a.UserName = u.UserName " +
                " WHERE a.UserName = @UserName AND u.Password = @Password ";
            try
            {
                using (SqlConnection connection = MedassistDB.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand cmnd = new SqlCommand(selectStatement, connection))
                    {
                        cmnd.Parameters.AddWithValue("@UserName", userName);
                        cmnd.Parameters.AddWithValue("@Password", password);
                        using (SqlDataReader reader = cmnd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                admin = new Administrator();
                                admin.UserName = reader["UserName"].ToString();
                                admin.Password = reader["Password"].ToString();
                                admin.AdminID = (int)reader["AdminID"];
                            }
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
            return admin;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedAssist.Model;
using System.Data;
using System.Data.SqlClient;

namespace MedAssist.DAL
{
    class NurseDAL
    {
        /// <summary>
        /// Returns nurse
        /// </summary>
        /// <param name="userName">The UserName</param>
        /// <param name="password">The Password</param>
        /// <returns>Nurse Object</returns>
        public static Nurse GetNurse( string userName, string password)
        {
            Nurse nurse = null;

            String selectStatement = " SELECT n.UserName, u.Password, n.NurseID " +
                " FROM Nurses n JOIN UserSecurity u ON n.UserName = u.UserName "+
                " WHERE n.UserName = @UserName AND u.Password = @Password ";
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
                                nurse = new Nurse();
                                nurse.UserName = reader["UserName"].ToString();
                                nurse.Password = reader["Password"].ToString();
                                nurse.NurseID = (int)reader["NurseID"];
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
            return nurse;
        }

        
    }
}
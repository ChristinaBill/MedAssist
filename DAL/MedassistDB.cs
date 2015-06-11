using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace MedAssist.DAL
{
    /// <summary>
    /// Gets a connection to the Medassist Database
    /// </summary>
    class MedassistDB
    {
        /// <summary>
        /// Returns the SqlConnection for the database
        /// </summary>
        /// <returns>The SQLConnection Object</returns>
        public static SqlConnection GetConnection()
        {
            string connectionString = "Data Source=localhost; Initial Catalog=cs6232-g5;" +
                "Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using MedAssist.Model;

namespace MedAssist.DAL
{
    /// <summary>
    /// Interacts with the Order table of the database
    /// </summary>
    class OrderDAL
    {
        public OrderDAL() { }

        /// <summary>
        /// Adds an Order item to the Order table
        /// </summary>
        /// <param name="tests">A Binding List of Tests</param>
        /// <param name="visitID">The Visit ID</param>
        /// <returns>True if successful</returns>
        public static bool OrderTests(BindingList<Test> tests, int visitID) 
        {
            int count = 0;
            SqlTransaction tran = null;
            SqlConnection connection = MedassistDB.GetConnection();
            string insertStatement =
                "Insert Orders " +
                "(OrderDate, TestID, VisitID) " +
                "Values (@OrderDate, @TestID, @VisitID)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            try
            {
                connection.Open();
                tran = connection.BeginTransaction();
                foreach (Test test in tests)
                {
                    insertCommand.Parameters.AddWithValue("@OrderDate", DateTime.Today);
                    insertCommand.Parameters.AddWithValue("@VisitID", visitID);
                    insertCommand.Parameters.AddWithValue("@TestID", test.TestID);
                    insertCommand.Transaction = tran;
                    count += insertCommand.ExecuteNonQuery();
                    insertCommand.Parameters.Clear();
                }
                if (count == tests.Count)
                {
                    tran.Commit();
                    return true;
                }
                else
                {
                    tran.Rollback();
                    return false;
                }
            }
            catch (SqlException ex)
            {
                tran.Rollback();
                throw ex;
            }
            finally
            {
                if (connection != null)
                connection.Close();
            }
        }

        /// <summary>
        /// Returns a binding list of OrderDetails
        /// </summary>
        /// <param name="patientID">The PatientID</param>
        /// <returns>The Binding List of OrderDetails</returns>
        public static BindingList<OrderDetails> GetPatientsOrdersWithDetails(int patientID)
        {
            BindingList<OrderDetails> orderList = new BindingList<OrderDetails>();
            SqlConnection connection = MedassistDB.GetConnection();
            String selectStatement = "SELECT o.OrderID, o.OrderDate, o.DatePerformed, o.Result, o.TestID, o.VisitID, " +
                "(p.LastName + ', ' + p.FirstName) AS PatientName, t.TestName " +
                "FROM Orders o JOIN Visits v ON o.VisitID = v.VisitID " +
                "JOIN Tests t ON t.TestID = o.TestID " +
                "JOIN Patients p ON v.PatientID = p.PatientID " +
                "WHERE p.PatientID = @PatientID";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@PatientID", patientID);
            SqlDataReader reader = null;
            try
            {
                connection.Open();
                reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    OrderDetails order = new OrderDetails();
                    order.OrderID = (int)reader["OrderID"];
                    order.OrderDate = (DateTime)reader["OrderDate"];
                    var result1 = reader["DatePerformed"];
                    if (result1 == DBNull.Value)
                    {
                        order.DatePerformed = null;
                    }
                    else
                    {
                        order.DatePerformed = (DateTime?)result1;
                    }
                    var result2 = reader["Result"];
                    if (result2 == DBNull.Value)
                    {
                        order.Result = null;
                    }
                    else
                    {
                        order.Result = result2.ToString()[0];
                    }
                    order.TestID = (int)reader["TestID"];
                    order.VisitID = (int)reader["VisitID"];
                    order.PatientName = reader["PatientName"].ToString();
                    order.TestName = reader["TestName"].ToString();
                    orderList.Add(order);
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
            return orderList;
        }

        /// <summary>
        /// Gets an Order object by OrderID
        /// </summary>
        /// <param name="orderID">The OrderID</param>
        /// <returns>Order object</returns>
        public static Order GetOrderByID(int orderID)
        {
            Order order = new Order();
            SqlConnection connection = MedassistDB.GetConnection();
            String selectStatement = "SELECT OrderID, OrderDate, DatePerformed, Result, TestID, VisitID " +
                "FROM Orders " +
                "WHERE OrderID = @OrderID";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@OrderID", orderID);
            SqlDataReader reader = null;
            try
            {
                connection.Open();
                reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    order.OrderID = (int)reader["OrderID"];
                    order.OrderDate = (DateTime)reader["OrderDate"];
                    var result1 = reader["DatePerformed"];
                    if (result1 == DBNull.Value)
                    {
                        order.DatePerformed = null;
                    }
                    else
                    {
                        order.DatePerformed = (DateTime?)result1;
                    }
                    var result2 = reader["Result"];
                    if (result2 == DBNull.Value)
                    {
                        order.Result = null;
                    }
                    else
                    {
                        order.Result = result2.ToString()[0];
                    }
                    order.TestID = (int)reader["TestID"];
                    order.VisitID = (int)reader["VisitID"];
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
            return order;
        }

        /// <summary>
        /// Updates the results and Dateperformed of an Order
        /// </summary>
        /// <param name="newOrder">The new Order</param>
        /// <param name="oldOrder">The old Order</param>
        /// <returns>True if successful</returns>
        public static bool UpdateResults(Order newOrder, Order oldOrder)
        {
            SqlConnection connection = MedassistDB.GetConnection();
            string updateStatement =
                "UPDATE Orders SET " +
                "Result = @Result, " +
                "DatePerformed = @DatePerformed " +
                "WHERE OrderID = @OldOrderID";
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            if (newOrder.Result == null)
            {
                int id = newOrder.TestID;
                updateCommand.Parameters.AddWithValue("@Result", (object)DBNull.Value);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@Result", newOrder.Result);
            }
            if (newOrder.Result == null)
            {
                updateCommand.Parameters.AddWithValue("@DatePerformed", (object)DBNull.Value);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@DatePerformed", newOrder.DatePerformed);
            }
            updateCommand.Parameters.AddWithValue("@OldOrderID", oldOrder.OrderID);
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

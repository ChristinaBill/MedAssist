using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using MedAssist.Model;
using MedAssist.DAL;

namespace MedAssist.Controller
{
    class OrderController
    {
        public OrderController() { }

        /// <summary>
        /// Creates order of tests for a visit
        /// </summary>
        /// <param name="tests">Test list</param>
        /// <param name="visitID">visit ID</param>
        /// <returns>true if successful</returns>
        public static bool OrderTests(BindingList<Test> tests, int visitID)
        {
            return OrderDAL.OrderTests(tests, visitID);
        }

        /// <summary>
        /// Gets order information for a patient
        /// </summary>
        /// <param name="patientID">patient id</param>
        /// <returns>the orders' details</returns>
        public static BindingList<OrderDetails> GetPatientsOrders(int patientID)
        {
            return OrderDAL.GetPatientsOrdersWithDetails(patientID);
        }

        /// <summary>
        /// Gets the order by id
        /// </summary>
        /// <param name="orderID">Order ID</param>
        /// <returns>Order</returns>
        public static Order GetOrderByID(int orderID)
        {
            return OrderDAL.GetOrderByID(orderID);
        }

        /// <summary>
        /// Updates results of order
        /// </summary>
        /// <param name="newOrder">the new order</param>
        /// <param name="oldOrder">the old order</param>
        /// <returns>true if successful</returns>
        public static bool UpdateResults(Order newOrder, Order oldOrder)
        {
            return OrderDAL.UpdateResults(newOrder, oldOrder);
        }
    }
}

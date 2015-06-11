using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedAssist.Controller;
using MedAssist.Model;

namespace MedAssist.View
{
    public partial class TestForm : Form
    {
        private BindingList<OrderDetails> orders;
        private Order newOrder;
        private Order oldOrder;
        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            try
            {
                txtPatient.Text = CurrentPatientController.currentPatient.FullName;
                orders = OrderController.GetPatientsOrders(CurrentPatientController.currentPatient.PatientID);
                this.FillComboBoxes();
                this.buildDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void FillComboBoxes()
        {
            cmbOrderID.DisplayMember = "OrderID";
            cmbOrderID.ValueMember = "OrderID";
            cmbOrderID.DataSource = orders;
            List<string> options = new List<string>();
            options.Add("\0");
            options.Add("-");
            options.Add("+");
            cmbResult.DataSource = options;
        }

        private void buildDGV()
        {
            try
            {
                orders = OrderController.GetPatientsOrders(CurrentPatientController.currentPatient.PatientID);
                dgvOrders.DataSource = orders;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            
        }

        private void getOrderAdjustments()
        {
            oldOrder = OrderController.GetOrderByID((int)cmbOrderID.SelectedValue);
            newOrder = OrderController.GetOrderByID((int)cmbOrderID.SelectedValue);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                char result = Convert.ToChar(cmbResult.SelectedItem.ToString());
                this.getOrderAdjustments();
                if (result == '-' || result == '+')
                {
                    newOrder.Result = result;
                    newOrder.DatePerformed = DateTime.Today;
                }
                else
                {
                    newOrder.Result = null;
                    newOrder.DatePerformed = null;
                }
                bool success = OrderController.UpdateResults(newOrder, oldOrder);
                if (success)
                {
                    MessageBox.Show("Test Updated", "Test Updated");
                }
                else
                {
                    MessageBox.Show("Test not updated, something went wrong. Try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            dgvOrders.DataSource = null;
            buildDGV();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you'd like to exit?", "Close Form?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }
    }
}

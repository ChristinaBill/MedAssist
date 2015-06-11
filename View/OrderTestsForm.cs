using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedAssist.Model;
using MedAssist.Controller;

namespace MedAssist.View
{
    public partial class OrderTestsForm : Form
    {
        private BindingList<Test> tests;

        public OrderTestsForm()
        {
            InitializeComponent();
            tests = new BindingList<Test>();
        }

        /// <summary>
        /// Adds a test to the Data Grid View and adds the test
        /// to a list of tests.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddTest_Click(object sender, EventArgs e)
        {
            Test test = this.GetTestData();
            tests.Add(test);
            this.buildDGV();
        }

        
        /// <summary>
        /// Builds the Data Grid View for Tests being added.
        /// </summary>
        private void buildDGV()
        {
            dgvTests.DataSource = tests;
        }

        /// <summary>
        /// Gets the Test from the comboBox and returns the Test
        /// </summary>
        /// <returns>The Test</returns>
        private Test GetTestData()
        {
            int testID = (int)cmbTest.SelectedValue;
            Test test = TestController.GetTestWithID(testID);
            return test;
        }

        /// <summary>
        /// Button that orders the tests currently in the list of tests
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrderTest_Click(object sender, EventArgs e)
        {
            if (dgvTests.RowCount == 0)
            {
                MessageBox.Show("There are no tests added to be ordered. Please select test and " +
                    "add it to the list before submission.", "Enter Routine Check");
            }
            else 
            {
                try
                {
                    bool result = OrderController.OrderTests(tests, CurrentVisitController.CurrentVisit.VisitID);
                    if (result == true)
                    {
                        MessageBox.Show("Orders were successfully placed and may be updated in Update Visit.", "Orders Placed");
                    }
                    else
                    {
                        MessageBox.Show("Whoops, something went wrong. Try again.", "Order Not Placed");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void testsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.testsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.testDataSet);
        }

        /// <summary>
        /// Controls what happens when the test loads.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderTestsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDataSet.Tests' table. You can move, or remove it, as needed.
            this.testsTableAdapter.Fill(this.testDataSet.Tests);
        }

        /// <summary>
        /// Button clears the data grid view.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            tests = new BindingList<Test>();
            dgvTests.DataSource = null;
            dgvTests.Refresh();
        }
    }
}

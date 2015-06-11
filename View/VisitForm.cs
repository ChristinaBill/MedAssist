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
using System.Text.RegularExpressions;

namespace MedAssist.View
{
    /// <summary>
    /// Form that allows a nurse to enter Visit information including the Checkup information
    /// </summary>
    public partial class VisitForm : Form
    {
        private List<Patient> patientList;
        private List<Employee> doctorList;
        private Visit oldVisit;
        private int visitID;
        private Visit visit;
        private BindingList<Test> tests;

        /// <summary>
        /// Initializes components and instance variables
        /// </summary>
        public VisitForm()
        {
            InitializeComponent();
            oldVisit = null;
            visit = new Visit();
            tests = new BindingList<Test>();
        }

        /// <summary>
        /// Carries out actions when the VisitForm loads, including loading the ComboBoxes and assigning Tags.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VisitForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDataSet.Tests' table. You can move, or remove it, as needed.
            this.testsTableAdapter.Fill(this.testDataSet.Tests);
            // TODO: This line of code loads data into the 'testDataSet.Tests' table. You can move, or remove it, as needed.
            this.testsTableAdapter.Fill(this.testDataSet.Tests);
            this.loadComboBoxes();
            txtDiastolic.Tag = "Diastolic Reading";
            txtBoxDiagnosis.Tag = "Diagnosis";
            txtHeartRate.Tag = "Heart Rate";
            txtNurse.Tag = "Nurse";
            txtRespRate.Tag = "Respiratory Rate";
            txtSymptoms.Tag = "Symptoms";
            txtSystolic.Tag = "Systolic Reading";
            txtTemp.Tag = "Temperature";
            cmbDoctor.Tag = "Doctor";
            cmbPatient.Tag = "Patient";
            txtNurse.Text = EmployeeController.GetEmployeeByID(UserSecurityController.NurseLoggedIn.NurseID).FullName;
            cmbDoctor.Select(); 
        }

        /// <summary>
        /// Gets the data from the form and returns it in the form of a Visit Object
        /// </summary>
        /// <returns>The Visit Object</returns>
        private Visit GetVisitData()
        {
            Visit aVisit = new Visit();
            try
            {
                aVisit.NurseID = (int)UserSecurityController.NurseLoggedIn.NurseID;
                aVisit.HeartRate = Int32.Parse(txtHeartRate.Text);
                aVisit.PatientID = (int)cmbPatient.SelectedValue;
                aVisit.RespirationRate = Int32.Parse(txtRespRate.Text);
                aVisit.Symptoms = txtSymptoms.Text;
                aVisit.Systolic = Int32.Parse(txtSystolic.Text);
                aVisit.Diastolic = Int32.Parse(txtDiastolic.Text);
                aVisit.DoctorID = (int)cmbDoctor.SelectedValue;
                if (!string.IsNullOrWhiteSpace(txtBoxDiagnosis.Text)) 
                {
                    aVisit.Diagnosis = txtBoxDiagnosis.Text;
                }
                else
                {
                    aVisit.Diagnosis = string.Empty;
                }
                aVisit.VisitDate = DateTime.Today;
                aVisit.Temperature = Decimal.Parse(txtTemp.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            return aVisit;
        }

        /// <summary>
        /// Checks if the data entered into the form is valid.
        /// </summary>
        /// <returns></returns>
        private bool IsValidData()
        {
            if (Validator.IsPresent(txtHeartRate) &&
                Validator.IsPresent(cmbPatient) &&
                Validator.IsPresent(txtNurse) &&
                Validator.IsPresent(txtRespRate) &&
                Validator.IsPresent(txtSymptoms) &&
                Validator.IsPresent(txtSystolic) &&
                Validator.IsPresent(txtDiastolic) &&
                Validator.IsPresent(cmbDoctor) &&
                Validator.IsPresent(txtTemp) &&
                Validator.IsInt32(txtDiastolic) &&
                Validator.IsInt32(txtHeartRate) &&
                Validator.IsInt32(txtRespRate) &&
                Validator.IsInt32(txtSystolic) &&
                Validator.IsDecimal(txtTemp))

            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// When the submit button is clicked it checks if the data is valid, 
        /// gets the data, and creates a new visit in the Visit table.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DialogResult yORn = MessageBox.Show("This form will close after submission. Are you sure you wouldn't like " +
                "to add anything or order more tests?", "Submit and Close?", MessageBoxButtons.YesNo);
            if (yORn == DialogResult.No)
            {
                return;
            }
            if (visitID == 0)
            {
                if (IsValidData())
                {
                    try
                    {
                        visit = this.GetVisitData();
                        visitID = VisitController.CreateVisit(visit);
                        MessageBox.Show("Visit " + visitID + " was successfully created.", "Visit Created");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                if (IsValidData())
                {
                    try
                    {
                        visit = this.GetVisitData();
                        bool result = VisitController.UpdateDiagnosis(visit, oldVisit);
                        if (result == false)
                        {
                            MessageBox.Show("Sorry, the visit has already been updated.", "Visit already updated.");
                        }
                        else
                        {
                            MessageBox.Show("Visit " + visitID + "'s diagnosis has been updated.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
            }
        }

        /// <summary>
        /// When the cancel button is clicked the user is asked if they are sure they
        /// want to cancel their form.  If confirmed the Form closes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you would like to exit the form? Information that " +
                "was confirmed has already been processed.", "Form Closing", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                this.Close();
            }
        }

        /// <summary>
        /// Loads the information into the Doctor ComboBox and the Patient ComboBox.
        /// </summary>
        private void loadComboBoxes()
        {
            EmployeeController empCont = new EmployeeController();
            PatientController patCont = new PatientController();
            try
            {
                doctorList = empCont.GetListOfDoctorEmployees();
                cmbDoctor.DataSource = doctorList;
                cmbDoctor.DisplayMember = "FullName";
                cmbDoctor.ValueMember = "EmployeeID";
                patientList = patCont.GetPatientList();
                cmbPatient.DataSource = patientList;
                cmbPatient.DisplayMember = "FullName";
                cmbPatient.ValueMember = "PatientID";
                cmbTest.DisplayMember = "TestName";
                cmbTest.ValueMember = "TestID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        /// <summary>
        /// Decides the actions taken when the Order Test Button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrderTest_Click(object sender, EventArgs e)
        {
            if (visitID == 0)
            {
                MessageBox.Show("Please submit Routine Check information before ordering Tests.", "Enter Routine Check");
            }
            else if (dgvTests.RowCount == 0)
            {
                MessageBox.Show("There are no tests added to be ordered. Please select test and " +
                    "add it to the list before submission.", "Enter Routine Check");
            }
            else 
            {
                try
                {
                    bool result = OrderController.OrderTests(tests, visitID);
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

        /// <summary>
        /// Decides the actions taken when the Update/View Button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViewUpdateTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature will be implemented soon", "Under Construction");
        }

        private void btnSubmitVitals_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                try
                {
                    visit = GetVisitData();
                    oldVisit = GetVisitData();
                    visitID = VisitController.CreateVisit(visit);
                    MessageBox.Show("Visit " + visitID + " was successfully created.", "Visit Created");
                    visit.VisitID = visitID;
                    oldVisit.VisitID = visitID;
                    this.disableFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
            else
            {
                return;
            }
        }

        /// <summary>
        /// Disables fields in the form
        /// </summary>
        private void disableFields()
        {
            txtDiastolic.Enabled = false;
            txtHeartRate.Enabled = false;
            txtNurse.Enabled = false;
            txtRespRate.Enabled = false;
            txtSymptoms.Enabled = false;
            txtSystolic.Enabled = false;
            txtTemp.Enabled = false;
            cmbPatient.Enabled = false;
            cmbDoctor.Enabled = false;
        }

        /// <summary>
        /// Adds a test to the Data Grid View and adds the test
        /// to a list of tests.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Test test = this.GetTestData();
            tests.Add(test);
            this.buildDGV();
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
        /// Builds the Data Grid View for Tests being added.
        /// </summary>
        private void buildDGV()
        {
            dgvTests.DataSource = tests;
        }

        /// <summary>
        /// Clears the Data Grid View
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            tests = new BindingList<Test>();
            dgvTests.DataSource = null;
            dgvTests.Refresh();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.testsTableAdapter.FillBy(this.testDataSet.Tests);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}

using MedAssist.Controller;
using MedAssist.DAL;
using MedAssist.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedAssist.View
{
    public partial class UpdateVisitForm : Form
    {
        private Visit visit;
        private int visitID;
        private List<Visit> visitDates;
        private List<Patient> patientList;
        private List<Employee> doctorList;

        /// <summary>
        /// Initializes the components and disables appropriate fields
        /// </summary>
        public UpdateVisitForm()
        {
            InitializeComponent();
            txtDiastolic.Enabled = false;
            txtSystolic.Enabled = false;
            txtHeartRate.Enabled = false;
            txtRespRate.Enabled = false;
            txtSymptoms.Enabled = false;
            txtTemp.Enabled = false;
            cboPatient.Enabled = false;
            cboDoctor.Enabled = false;
            txtNurse.Enabled = false;
            txtBoxFnlDiagnosis.Enabled = true;
            txtBoxDiagnosis.Enabled = false;
            txtNurse.Text = EmployeeController.GetEmployeeByID(UserSecurityController.NurseLoggedIn.NurseID).FullName;
            CurrentPatientController.currentPatient = null;
            
        }

        /// <summary>
        /// Sets the visitCombobox
        /// </summary>
        /// <param name="firstName">Patients first name</param>
        /// <param name="lastName">Patients last name</param>
        private void GetVisitsByPatient(string firstName, string lastName)
        {
            visitDates = VisitDAL.GetListVisitDates(firstName, lastName);
            cboVisits.DataSource = visitDates;
            cboVisits.DisplayMember = "VisitDateID";
            cboVisits.ValueMember = "VisitID";
        }

        /// <summary>
        /// Loads the fields with the visit info.
        /// </summary>
        /// <param name="visitID">The visit ID</param>
        private void GetVisitInfo(int visitID)
        {
            try
            {
                visit = VisitDAL.GetVisitToUpdate(visitID);
                if (visit == null)
                    MessageBox.Show("No Visit found with this Visit ID. " +
                                    "Please try again.", "Visit Not Found");
                else
                {
                    CurrentVisitController.CurrentVisit = VisitDAL.GetVisitToUpdate(visitID);
                    this.DisplayVisit();
                    CurrentPatientController.currentPatient = PatientController.GetPatientWithID(visit.PatientID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        /// <summary>
        /// Helper that loads the fields with Visit Info.
        /// </summary>
        private void DisplayVisit()
        {
            cboDoctor.SelectedText = EmployeeController.GetEmployeeByID(visit.DoctorID).FullName;
            cboPatient.SelectedText = PatientController.GetPatientWithID(visit.PatientID).FullName;
            cboPatient.SelectedValue = 
            txtSystolic.Text = visit.Systolic.ToString();
            txtDiastolic.Text = visit.Diastolic.ToString();
            txtHeartRate.Text = visit.HeartRate.ToString();
            txtTemp.Text = visit.Temperature.ToString();
            txtRespRate.Text = visit.RespirationRate.ToString();
            txtSymptoms.Text = visit.Symptoms;
            txtBoxDiagnosis.Text = visit.Diagnosis;
        }

        /// <summary>
        /// Searches for visit info by first and last name when button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchVisit_Click(object sender, EventArgs e)
        {

            if (Validator.IsPresent(txtSearchFirstName) &&
                Validator.IsPresent(txtSearchLastName))
            {
                string firstName = txtSearchFirstName.Text;
                string lastName = txtSearchLastName.Text;
                this.GetVisitsByPatient(firstName, lastName);
            }
        }

        /// <summary>
        /// Sets the Diagnosis information for a Visit object
        /// </summary>
        /// <param name="visit">the visit</param>
        private void PutVisitData(Visit visit)
        {
                visit.Diagnosis = txtBoxDiagnosis.Text + ", " + txtBoxFnlDiagnosis.Text;
        }

        /// <summary>
        /// Checks if the search fields are valid.
        /// </summary>
        /// <returns></returns>
        private bool IsValidData()
        {
            if (Validator.IsPresent(txtSearchFirstName) &&
                Validator.IsPresent(txtSearchLastName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Updates the visit when the submit button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            visit.VisitID = visitID;
            Visit newVisit = new Visit();
            newVisit.VisitID = visit.VisitID;
            this.PutVisitData(newVisit);

                try
                {
                    if (!VisitDAL.UpdateVisit(visit, newVisit))
                    {
                        MessageBox.Show("Another user has updated or " +
                                        "deleted that visit.", "Database Error");
                        this.DialogResult = DialogResult.Retry;
                    }
                    else
                    {
                        visit = newVisit;
                        this.DialogResult = DialogResult.OK;
                        MessageBox.Show("Visit Updated");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }

        }

        /// <summary>
        /// Closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you would like to exit the form?", "Form Closing", MessageBoxButtons.YesNo);
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
        /// Loads the ComboBoxes for doctor and patient
        /// </summary>
        private void loadComboBoxes()
        {
            EmployeeController empCont = new EmployeeController();
            PatientController patCont = new PatientController();
            try
            {
                doctorList = empCont.GetListOfDoctorEmployees();
                cboDoctor.DataSource = doctorList;
                cboDoctor.DisplayMember = "FullName";
                cboDoctor.ValueMember = "EmployeeID";
                patientList = patCont.GetPatientList();
                cboPatient.DataSource = patientList;
                cboPatient.DisplayMember = "FullName";
                cboPatient.ValueMember = "PatientID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        /// <summary>
        /// Gets the visit info when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetVisitInfo_Click(object sender, EventArgs e)
        {

            visitID = Convert.ToInt32(cboVisits.SelectedValue);
            this.GetVisitInfo(visitID);

        }

        /// <summary>
        /// Opens the View/Update Tests form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViewUpdateTest_Click(object sender, EventArgs e)
        {
            try
            {
                if (CurrentPatientController.currentPatient != null)
                {
                    TestForm tf = new TestForm();
                    tf.Show();
                }
                else
                {
                    MessageBox.Show("Please select a patient and visit before reviewing tests", "Patient Selection Needed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        /// <summary>
        /// Orders test
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CurrentPatientController.currentPatient != null)
                {
                    OrderTestsForm otf = new OrderTestsForm();
                    otf.Show();
                }
                else
                {
                    MessageBox.Show("Please select a patient and visit before reviewing tests", "Patient Selection Needed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}

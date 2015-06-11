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
    /// <summary>
    /// Update Patient form
    /// </summary>
    public partial class UpdatePatientForm : Form
    {

        private Patient patient;

        /// <summary>
        /// Initializes the form
        /// </summary>
        public UpdatePatientForm()
        {
            InitializeComponent();
            txtDOB.Enabled = false;
            txtSSN.Enabled = false;
            txtGender.Enabled = false;
            txtMiddleInit.MaxLength = 1;
            txtPhone.MaxLength = 10;
            txtZip.MaxLength = 10;

        }

        /// <summary>
        /// Gets a Patient using their ID and displays their info.
        /// </summary>
        /// <param name="patientID"></param>
        private void GetPatient(int patientID)
        {
            try
            {
                patient = PatientDAL.GetPatientToUpdate(patientID);
                if (patient == null)
                    MessageBox.Show("No Patient found with this ID. " +
                                    "Please try again.", "Patient Not Found");
                else
                {
                    this.DisplayPatient();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        /// <summary>
        /// Gets patients with no id
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="DOB"></param>
        private void GetPatientWithNoID(string firstName, string lastName, DateTime DOB)
        {
            try
            {
                patient = PatientDAL.GetPatientToUpdateWithNoID(firstName, lastName, DOB);
                if (firstName == null)
                    MessageBox.Show("First Name is required " +
                                    "Please try again.", "Patient Not Found");
                else if (lastName == null)
                    MessageBox.Show("Last Name is required " +  
                       "Please try again.", "Patient Not Found");
                else if (DOB == null)
                    MessageBox.Show("Date of Birth is required " +
                       "Please try again.", "Patient Not Found");
                else if (patient == null)
                    MessageBox.Show("No Patient found. " +
                                    "Please try again.", "Patient Not Found");

                else

                {
                    this.DisplayPatient();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        /// <summary>
        /// Loads the Patient information to the form
        /// </summary>
        private void DisplayPatient()
        {           
            txtFirstName.Text = patient.FirstName;
            txtMiddleInit.Text = patient.MInit;
            txtLastName.Text = patient.LastName;
            txtAddress1.Text = patient.StreetAddr1;
            txtAddress2.Text = patient.StreetAddr2;
            txtCity.Text = patient.City;
            cboState.Text = patient.State;
            txtZip.Text = patient.ZipCode;
            txtPhone.Text = patient.Phone;
            txtDOB.Text = patient.DOB.ToString();
            txtSSN.Text = patient.SSN;
            txtGender.Text = patient.Gender.ToString();
        }
        
        /// <summary>
        /// Designates the actions carried out when the Submit button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Patient newPatient = new Patient();


            if (IsValidData())
            {
                newPatient.PatientID = patient.PatientID;
                this.PutPatientData(newPatient);

                try
                {
                    if (!PatientDAL.UpdatePatient(patient, newPatient))
                    {
                        MessageBox.Show("Another user has updated or " +
                                        "deleted that patient.", "Database Error");
                        this.DialogResult = DialogResult.Retry;
                    }
                    else
                    {
                        patient = newPatient;
                        this.DialogResult = DialogResult.OK;
                        MessageBox.Show("Patient Updated");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        /// <summary>
        /// Checks if the data is valid
        /// </summary>
        /// <returns>True if it is, false if it isn't</returns>
        private bool IsValidData()
        {
           if (Validator.IsPresent(txtFirstName) &&
               Validator.IsPresent(txtLastName) &&
               Validator.IsPresent(txtAddress1) &&
               Validator.IsPresent(txtCity) &&
               Validator.IsPresent(cboState) &&
               Validator.IsInt64(txtPhone) &&
               Validator.IsInt32(txtSSN) &&
               Validator.IsInt64(txtZip))
           {
               return true;
           }
           return false;
       }
        
        /// <summary>
        /// Sets the patients attributesbfrom the fields in the form
        /// </summary>
        /// <param name="patient">the Patient</param>
        private void PutPatientData(Patient patient)
        {
            txtMiddleInit.MaxLength = 1;
            patient.FirstName = txtFirstName.Text;
            patient.LastName = txtLastName.Text;

            if (txtMiddleInit.Text != " ")
            {
                patient.MInit = txtMiddleInit.Text;
            }

            
            patient.StreetAddr1 = txtAddress1.Text;
            patient.StreetAddr2 = txtAddress2.Text;
            patient.City = txtCity.Text;
            patient.State = cboState.Text;
            patient.Phone = txtPhone.Text;
            patient.ZipCode = txtZip.Text;
        }
        
        /// <summary>
        /// Sets the actions taken when Get Patient button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetPatient_Click(object sender, EventArgs e)
        {
            
            if (Validator.IsPresent(txtPatientID) &&
                Validator.IsInt32(txtPatientID))
            {
                int patientID = Convert.ToInt32(txtPatientID.Text);
                this.GetPatient(patientID);
            }
         }


        /// <summary>
        /// Sets the actions taken when the Cancel Button is clicked.
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


        private void txtPatientID_TextChanged(object sender, EventArgs e)
        {


        }

        /// <summary>
        /// gets patient info on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPatientInfo_Click(object sender, EventArgs e)
        {

            if (Validator.IsPresent(txtSearchFirstName) &&
                Validator.IsPresent(txtSearchLastName) &&
                Validator.IsPresent(dateTimePickerSearchDOB))
            {
                string firstName = txtSearchFirstName.Text;
                string lastName = txtSearchLastName.Text;
                DateTime dob = dateTimePickerSearchDOB.Value.Date;
                this.GetPatientWithNoID(firstName, lastName, dob);
            }
 

        }

        private void dateTimePickerSearchDOB_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerSearchDOB.Format = DateTimePickerFormat.Short;
        }


       
    }
}

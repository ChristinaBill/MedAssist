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
    /// <summary>
    /// Form allows the user to Update information about an employee
    /// </summary>
    public partial class UpdateDeleteEmployeeForm : Form
    {
        private bool isDoctor;
        private bool isNurse;
        private bool isAdmin;
        private Employee employee;
        private Employee oldEmployee;

        /// <summary>
        /// Initializes the components
        /// </summary>
        public UpdateDeleteEmployeeForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Controls the actions taken when the form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateDeleteEmployeeForm_Load(object sender, EventArgs e)
        {
            this.disableFields();
        }

        /// <summary>
        /// Disables the fields
        /// </summary>
        private void disableFields()
        {
            txtCity.Enabled = false;
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtMinit.Enabled = false;
            txtPhone.Enabled = false;
            txtSSN.Enabled = false;
            txtState.Enabled = false;
            txtStreet.Enabled = false;
            txtStreet2.Enabled = false;
            rBtnAdmin.Enabled = false;
            rBtnDoctor.Enabled = false;
            rBtnFemale.Enabled = false;
            rBtnMale.Enabled = false;
            rBtnNurse.Enabled = false;
            btnUpdate.Enabled = false;
            dtpDOB.Enabled = false;
            chkEnabled.Enabled = false;
        }

        /// <summary>
        /// Enables the fields
        /// </summary>
        private void enableFields()
        {
            txtCity.Enabled = true;
            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;
            txtMinit.Enabled = true;
            txtPhone.Enabled = true;
            txtSSN.Enabled = true;
            txtState.Enabled = true;
            txtStreet.Enabled = true;
            txtStreet2.Enabled = true;
            rBtnFemale.Enabled = true;
            rBtnMale.Enabled = true;
            btnUpdate.Enabled = true;
            dtpDOB.Enabled = true;
            chkEnabled.Enabled = true;
        }

        /// <summary>
        /// Checks if the data entered into the form is valid.
        /// </summary>
        /// <returns>true if valid information</returns>
        private bool IsValidEmployeeData()
        {
            if (Validator.IsPresent(txtCity) &&
                Validator.IsPresent(txtFirstName) &&
                Validator.IsPresent(txtLastName) &&
                Validator.IsPresent(txtPhone) &&
                Validator.IsPresent(txtSSN) &&
                Validator.IsPresent(txtState) &&
                Validator.IsPresent(txtStreet) &&
                Validator.IsPresent(txtZip) &&
                Validator.IsInt64(txtZip) &&
                Validator.IsInt64(txtPhone) &&
                Validator.IsState(txtState) &&
                Validator.IsInt32(txtSSN) &&
                this.IsValidEmployeeID())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Returns if the EmployeeID is valid.
        /// </summary>
        /// <returns>True if it is.</returns>
        private bool IsValidEmployeeID()
        {
            if (Validator.IsPresent(txtEmployeeID) &&
                Validator.IsInt32(txtEmployeeID))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// When the Search button is clicked the Employee ID is used to find the
        /// employee and fill in the information.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            oldEmployee = null;
            if (this.IsValidEmployeeID()) 
            {
                try
                {
                    oldEmployee = EmployeeController.GetEmployeeByID(Int32.Parse(txtEmployeeID.Text));
                    this.fillEmployeeData();
                    fillEmployeePosition(oldEmployee.EmployeeID);
                    this.enableFields();
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("There is no Employee with that EmployeeID. Try again.");
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
        /// Fills the fields with the employees data.
        /// </summary>
        private void fillEmployeeData()
        {
            if (oldEmployee != null)
            {
                try
                {
                    txtCity.Text = oldEmployee.City;
                    txtFirstName.Text = oldEmployee.FirstName;
                    txtLastName.Text = oldEmployee.LastName;
                    if (oldEmployee.MInit != " ")
                    {
                        txtMinit.Text = oldEmployee.MInit;
                    }
                    txtPhone.Text = oldEmployee.Phone.ToString();
                    txtSSN.Text = oldEmployee.SSN.ToString();
                    txtState.Text = oldEmployee.State;
                    txtStreet.Text = oldEmployee.StreetAddr1;
                    txtStreet2.Text = oldEmployee.StreetAddr2;
                    txtZip.Text = oldEmployee.ZipCode;
                    dtpDOB.Value = oldEmployee.DOB;
                    if (oldEmployee.Gender == 'm' || oldEmployee.Gender == 'M')
                    {
                        rBtnMale.Checked = true;
                    }
                    if (oldEmployee.Gender == 'f' || oldEmployee.Gender == 'F')
                    {
                        rBtnFemale.Checked = true;
                    }
                    if (oldEmployee.Inactive)
                    {
                        chkEnabled.Checked = false;
                    }
                    else
                    {
                        chkEnabled.Checked = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        /// <summary>
        /// Fills the appropriate radiobutton depending on the employees position.
        /// </summary>
        /// <param name="employeeID">The employeeID</param>
        private void fillEmployeePosition(int employeeID) 
        {
            if (EmployeeController.isEmployeeDoctor(employeeID))
            {
                rBtnDoctor.Checked = true;
                this.isDoctor = true;
            }
            else if (EmployeeController.isEmployeeNurse(employeeID))
            {
                rBtnNurse.Checked = true;
                this.isNurse = true;
            }
            else if (EmployeeController.isEmployeeAdmin(employeeID))
            {
                rBtnAdmin.Checked = true;
                this.isAdmin = true;
            }
            else
            {
                MessageBox.Show("Employee\'s position has not been established yet.  Please select one and update it.");
            }
        }

        /// <summary>
        /// Updates the employee and closes the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsValidEmployeeData())
            {
                try
                {
                    getEmployeeData();
                    bool success = EmployeeController.UpdateEmployee(oldEmployee, employee);
                    if (success)
                    {
                        MessageBox.Show("Employee " + " " + txtEmployeeID.Text + " was updated properly.", "Employee Updated");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Either the Employee was already updated or there was another conflict. " +
                            "Employee was not updated.", "Employee Not Updated!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        /// <summary>
        /// Closes the form if user agrees they want to.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you'd like to close the form?", "Close Form?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Loads the data from the form to the Employee object.
        /// </summary>
        private void getEmployeeData()
        {
            if (IsValidEmployeeData())
            {
                try
                {
                    employee = new Employee();
                    employee.City = txtCity.Text;
                    employee.FirstName = txtFirstName.Text;
                    employee.LastName = txtLastName.Text;
                    employee.MInit = txtMinit.Text;
                    employee.Phone = txtPhone.Text;
                    employee.SSN = txtSSN.Text;
                    employee.State = txtState.Text;
                    employee.ZipCode = txtZip.Text;
                    employee.StreetAddr1 = txtStreet.Text;
                    employee.StreetAddr2 = txtStreet2.Text;
                    employee.DOB = dtpDOB.Value;
                    if (rBtnMale.Checked)
                    {
                        employee.Gender = 'M';
                    }
                    if (rBtnFemale.Checked)
                    {
                        employee.Gender = 'F';
                    }
                    if (chkEnabled.Checked)
                    {
                        employee.Inactive = false;
                    }
                    else
                    {
                        employee.Inactive = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void chkEnabled_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
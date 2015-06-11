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
    /// Add new Employees
    /// </summary>
    public partial class AddEmployeeForm : Form
    {
        private Employee employee;
        private string userName;

        /// <summary>
        /// Initializes the components and sets maxlength of fields
        /// </summary>
        public AddEmployeeForm()
        {
            InitializeComponent();
            txtMInit.MaxLength = 1;
            txtPhone.MaxLength = 10;
            txtZip.MaxLength = 10;
            txtSSN.MaxLength = 9;
        }

        /// <summary>
        /// gets patient data from form
        /// </summary>
        /// <param name="employee"></param>
        private void PutEmployeeData(Employee employee)
        {
                employee.FirstName = txtFirstName.Text;
                employee.LastName = txtLastName.Text;
                employee.MInit = txtMInit.Text;
                employee.StreetAddr1 = txtStreetAddress1.Text;
                employee.StreetAddr2 = txtStreetAddress2.Text;
                employee.City = txtCity.Text;
                employee.State = cboState.Text;
                employee.SSN = txtSSN.Text;
                employee.Phone = txtPhone.Text;
                employee.Gender = cboGender.Text[0];
                employee.ZipCode = txtZip.Text;
                employee.DOB = dateTimePickerDOB.Value.Date;
         }

        /// <summary>
        /// creates new employee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                employee = new Employee();
                PutEmployeeData(employee);
                UserSecurityDAL.AddEmployee(employee);
                
                try
                {
                    if (radioButtonDoctor.Checked)
                    {
                        employee.Type = Employee.EmployeeType.Doctor;
                        EmployeeDAL.AddEmployee(employee);
                        DialogResult = DialogResult.OK;
                        MessageBox.Show("Employee Accepted");
                        Close();
                    }
                    else if (radioButtonNurse.Checked)
                    {
                        
                        employee.Type = Employee.EmployeeType.Nurse;
                        EmployeeDAL.AddEmployee(employee);
                        DialogResult = DialogResult.OK;
                        MessageBox.Show("Employee Accepted");
                        Close();
                    }
                    else if (radioButtonAdmin.Checked)
                    {

                        employee.Type = Employee.EmployeeType.Admin;
                        EmployeeDAL.AddEmployee(employee);
                        DialogResult = DialogResult.OK;
                        MessageBox.Show("Employee Accepted");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Employee type not chosen.");
                    }


                }
                catch (Exception ex)
                {
                    {
                        
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }

            }
        }

        /// <summary>
        /// cancels form
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
        /// validates data
        /// </summary>
        /// <returns></returns>
        private bool IsValidData()
        {
            if (Validator.IsPresent(txtFirstName) &&
                Validator.IsPresent(txtLastName) &&
                Validator.IsPresent(txtStreetAddress1) &&
                Validator.IsPresent(txtSSN) &&
                Validator.IsPresent(txtCity) &&
                Validator.IsPresent(cboState) &&
                Validator.IsPresent(txtPhone) &&
                Validator.IsPresent(dateTimePickerDOB) &&
                Validator.IsPresent(cboGender) &&
                Validator.IsInt64(txtPhone) &&
                Validator.IsInt64(txtZip) &&
                Validator.IsInt32(txtSSN))
            {
                return true;
            }
            return false;
        }
    }
}

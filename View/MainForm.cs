using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedAssist.Controller;
using MedAssist.Model;
using MedAssist.DAL;

namespace MedAssist.View
{
    /// <summary>
    /// Parent Form of the program with a menubar that opens the rest of the forms.
    /// </summary>
    public partial class MainForm : Form
    {
        NewPatient np;
        UpdatePatientForm up;
        VisitForm vf;
        SearchPatient sp;
        ChangePasswordForm cpf;
        Thread th;

        /// <summary>
        /// Initializes the components
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Controls what happens when the Main Form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Opens the Register Patient Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void registerPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserSecurityController.AdminLoggedIn != null)
            {
                MessageBox.Show("You are not authorized to access this. ", "Access denied");
            }
            else
            {

            if (np == null)
            {
                np = new NewPatient();
                np.MdiParent = this;
                np.FormClosed += new FormClosedEventHandler(np_FormClosed);
                np.Show();
            }
            else
            {
                np.Activate();
            }
        }
        }

        /// <summary>
        /// Helper form so that above form only has one instance at a time.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void np_FormClosed(object sender, FormClosedEventArgs e)
        {
            np = null;
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Opens the Update Patient Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updatePatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserSecurityController.AdminLoggedIn != null)
            {
                MessageBox.Show("You are not authorized to access this. ", "Access denied");
            }
            else
            {

            if (up == null)
            {
                up = new UpdatePatientForm();
                up.MdiParent = this;
                this.up.FormClosed += up_FormClosed;

                up.Show();

            }
            else
            {
                up.Activate();
            }
            }

        }

        /// <summary>
        /// Helper form so that above form only has one instance at a time.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void up_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.up = null;
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Closes the Application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Displays warning for not being logged in.
        /// </summary>
        private void DisplayLoginWarning()
        {
            MessageBox.Show("You must login to get access. Go to the Account menu to login", "Access denied");
        }

        /// <summary>
        /// Opens the Search Patient Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserSecurityController.AdminLoggedIn != null)
            {
                MessageBox.Show("You are not authorized to access this. ", "Access denied");
            }
            else
            {


            if (sp == null)
            {
                sp = new MedAssist.View.SearchPatient();
                sp.StartPosition = FormStartPosition.Manual;
                sp.MdiParent = this;
                sp.FormClosed += new FormClosedEventHandler(sp_FormClosed);
                sp.Show();
            }
            else
                {
                sp.Activate();
                }
            }

        }

        /// <summary>
        /// Helper form so that above form only has one instance at a time.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sp_FormClosed(object sender, FormClosedEventArgs e)
        {
            sp = null;
        }

        /// <summary>
        /// Logs out the user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            UserSecurityController.NurseLoggedIn = null;
                UserSecurityController.AdminLoggedIn = null;
            this.Close();
            this.th = new Thread(openLoginForm);
            this.th.SetApartmentState(ApartmentState.STA);
            this.th.Start();
        }

        /// <summary>
        /// Opens the FormLogin when the application begins.
        /// </summary>
        /// <param name="obj"></param>
        private void openLoginForm(object obj)
        {
            Application.Run(new FormLogin());
        }

        private void newVisitToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (UserSecurityController.AdminLoggedIn != null)
            {
                MessageBox.Show("You are not authorized to access this. ", "Access denied");
            }
            else
            {

                if (vf == null)
                {
                    vf = new VisitForm();
                    vf.MdiParent = this;
                    vf.FormClosed += new FormClosedEventHandler(vf_FormClosed);
                    vf.Show();
                }
                else
                {
                    vf.Activate();
                }

            }
        }
        /// <summary>
        /// Helper form so that above form only has one instance at a time.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void vf_FormClosed(object sender, FormClosedEventArgs e)
        {
            vf = null;
        }

        /// <summary>
        /// Opens menu for changing the users password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cpf == null)
            {
                cpf = new ChangePasswordForm();
                cpf.MdiParent = this;
                cpf.FormClosed += new FormClosedEventHandler(cpf_FormClosed);
                cpf.Show();
            }
            else
            {
                cpf.Activate();
            }
        }
        /// <summary>
        /// Helper form so that above form only has one instance at a time.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void cpf_FormClosed(object sender, FormClosedEventArgs e)
        {
            cpf = null;
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Opens the update visit form
        /// </summary>
        UpdateVisitForm uvf;
        private void updateVisitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserSecurityController.AdminLoggedIn != null)
            {
                MessageBox.Show("You are not authorized to access this. ", "Access denied");
            }
            else
            {

                if (uvf == null)
                {
                    uvf = new UpdateVisitForm();
                    uvf.MdiParent = this;
                    uvf.FormClosed += new FormClosedEventHandler(uvf_FormClosed);
                    uvf.Show();
                }
                else
                {
                    uvf.Activate();
                }
            }
        }
        /// <summary>
        /// Helper form so that above form only has one instance at a time.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void uvf_FormClosed(object sender, FormClosedEventArgs e)
        {
            uvf = null;
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Opens the Reports form
        /// </summary>
        ReportForm rf;
        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
                if (UserSecurityController.NurseLoggedIn != null)
                {
                    MessageBox.Show("You are not authorized to access this. ", "Access denied");
                }
                else
                {
                if (rf == null)
                {
                    rf = new ReportForm();
                    rf.MdiParent = this;
                    rf.FormClosed += new FormClosedEventHandler(rf_FormClosed);
                    rf.Show();
                }
                else
                {
                    rf.Activate();
                }
            }
        }
        /// <summary>
        /// Helper form so that above form only has one instance at a time.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void rf_FormClosed(object sender, FormClosedEventArgs e)
        {
            rf = null;
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Opens the Update Employee form
        /// </summary>
        UpdateDeleteEmployeeForm udef;
        private void updateEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserSecurityController.NurseLoggedIn != null)
            {
                MessageBox.Show("You are not authorized to access this. ", "Access denied");
            }
            else
            {

                if (udef == null)
                {
                    udef = new UpdateDeleteEmployeeForm();
                    udef.MdiParent = this;
                    udef.FormClosed += new FormClosedEventHandler(udef_FormClosed);
                    udef.Show();
                }
                else
                {
                    udef.Activate();
                }
            }
        }
        /// <summary>
        /// Helper form so that above form only has one instance at a time.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void udef_FormClosed(object sender, FormClosedEventArgs e)
        {
            udef = null;
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Opens the Add Employee Form
        /// </summary>
        AddEmployeeForm aef;
        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserSecurityController.NurseLoggedIn != null)
            {
                MessageBox.Show("You are not authorized to access this. ", "Access denied");
            }
            else
            {

                if (aef == null)
                {
                    aef = new AddEmployeeForm();
                    aef.MdiParent = this;
                    aef.FormClosed += new FormClosedEventHandler(aef_FormClosed);
                    aef.Show();

                }
                else
                {
                    aef.Activate();
                }
            }
        }
        /// <summary>
        /// Helper form so that above form only has one instance at a time.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void aef_FormClosed(object sender, FormClosedEventArgs e)
        {
            aef = null;
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Opens the Add Test Form
        /// </summary>
        AddTestForm atf;
        private void addTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserSecurityController.NurseLoggedIn != null)
            {
                MessageBox.Show("You are not authorized to access this. ", "Access denied");
            }
            else
            {

                if (atf == null)
                {
                    atf = new AddTestForm();
                    atf.MdiParent = this;
                    atf.FormClosed += new FormClosedEventHandler(atf_FormClosed);
                    atf.Show();

                }
                else
                {
                    atf.Activate();
                }
            }
        }
        /// <summary>
        /// Helper form so that above form only has one instance at a time.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void atf_FormClosed(object sender, FormClosedEventArgs e)
        {
            atf = null;
            //throw new NotImplementedException();
        }


        /// <summary>
        /// Opens the Update Test Form
        /// </summary>
        UpdateTestForm utf;
        private void updateTestToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (UserSecurityController.NurseLoggedIn != null)
            {
                MessageBox.Show("You are not authorized to access this. ", "Access denied");
            }
            else
            {

            if (utf == null)
            {
                utf = new UpdateTestForm();
                utf.MdiParent = this;
                utf.FormClosed += new FormClosedEventHandler(utf_FormClosed);
                utf.Show();

            }
            else
            {
                utf.Activate();
            }

            }
        }
        /// <summary>
        /// Helper form so that above form only has one instance at a time.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void utf_FormClosed(object sender, FormClosedEventArgs e)
        {
            utf = null;
            //throw new NotImplementedException();
        }
    }
}




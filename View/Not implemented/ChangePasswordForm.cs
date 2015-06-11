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
    public partial class ChangePasswordForm : Form
    {
       
        private UserSecurity newUserSecurity;
        private UserSecurity oldUserSecurity;
        public ChangePasswordForm()
        {
            InitializeComponent();
           
            this.newUserSecurity = new UserSecurity();
            this.oldUserSecurity = new UserSecurity();
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            txtUserName.Text = this.oldUserSecurity.UserName;
            txtOldPassword.Text = this.oldUserSecurity.Password;

            string newPassword = txtNewPassword.Text;
           
           
           try
           {
               if (txtNewPassword.Text != txtOldPassword.Text)

                UserSecurityController.UpdatePassword(this.oldUserSecurity, this.newUserSecurity);
             
                   //MessageBox.Show("Password changed");
               
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
           }

        }

        private void PutData()
        {

        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
    }
}

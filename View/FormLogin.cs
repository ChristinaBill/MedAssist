using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;
using MedAssist.Controller;
using MedAssist.DAL;
using MedAssist.Model;

namespace MedAssist.View
{
    //TODO: Create Static Class that keeps track of Employee logged in.
    //TODO: Create method that can be used to check if a nurse is logged in.   ----   I can help with some of this stuff.  Let me know.
    public partial class FormLogin : Form
    {
        private ControllerNurse controllerNurse;
        private ControllerAdmin adminController;
        private Administrator admin;
        private Nurse nurse;
        private MainForm mainForm;

        /// <summary>
        /// Initializes the components and instance variables.
        /// </summary>
        public FormLogin()
        {
            InitializeComponent();
            this.controllerNurse = new ControllerNurse();
            this.adminController = new ControllerAdmin();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// The method manages a nurse login, so that he/she can get access to other 
        /// applications after login button is clicked 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button1_Click(object sender, EventArgs e)
        {
            string userName = textBoxUserName.Text;
            string password = MD5Hash(textBoxPassword.Text);
            if (Validator.IsPresent(textBoxUserName) &&
                Validator.IsPresent(textBoxPassword));
            {
                try
                {
                    this.nurse = this.controllerNurse.GetNurse(userName, password);
                    this.admin = this.adminController.GetAdmin(userName, password);
                    UserSecurityController.AdminLoggedIn = this.admin;
                    UserSecurityController.NurseLoggedIn = this.nurse;
                    if (this.nurse != null || this.admin != null)
                    {
                        this.mainForm = new MainForm();
                        this.mainForm.Text = "You are logged in as  " + userName;
                        if (this.mainForm.ShowDialog() == DialogResult.OK)
                        {
                            this.mainForm.Show();
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid user name or password.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        


        /// <summary>
        /// Closes login form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you would like to exit?", "Exit Login?", MessageBoxButtons.YesNo);
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
        /// Encrypts text
        /// </summary>
        /// <param name="text">the text</param>
        /// <returns>The encrypted text</returns>
        public string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            //get hash result after compute it
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits
                //for each byte
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }

    
    }
}

namespace MedAssist.View
{
    partial class AddEmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancel = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButtonAdmin = new System.Windows.Forms.RadioButton();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStreetAddress2 = new System.Windows.Forms.TextBox();
            this.radioButtonNurse = new System.Windows.Forms.RadioButton();
            this.radioButtonDoctor = new System.Windows.Forms.RadioButton();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStreetAddress1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtMInit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(267, 235);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(261, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 60;
            this.label10.Text = "DOB";
            // 
            // txtSSN
            // 
            this.txtSSN.Location = new System.Drawing.Point(107, 108);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(100, 20);
            this.txtSSN.TabIndex = 7;
            this.txtSSN.Tag = "SSN";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 58;
            this.label9.Text = "SSN";
            // 
            // radioButtonAdmin
            // 
            this.radioButtonAdmin.AutoSize = true;
            this.radioButtonAdmin.Location = new System.Drawing.Point(348, 21);
            this.radioButtonAdmin.Name = "radioButtonAdmin";
            this.radioButtonAdmin.Size = new System.Drawing.Size(54, 17);
            this.radioButtonAdmin.TabIndex = 3;
            this.radioButtonAdmin.TabStop = true;
            this.radioButtonAdmin.Text = "Admin";
            this.radioButtonAdmin.UseVisualStyleBackColor = true;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(291, 137);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(148, 20);
            this.txtCity.TabIndex = 10;
            this.txtCity.Tag = "City";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(258, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "State";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "City";
            // 
            // txtStreetAddress2
            // 
            this.txtStreetAddress2.Location = new System.Drawing.Point(107, 160);
            this.txtStreetAddress2.Name = "txtStreetAddress2";
            this.txtStreetAddress2.Size = new System.Drawing.Size(148, 20);
            this.txtStreetAddress2.TabIndex = 11;
            this.txtStreetAddress2.Tag = "Street Address 1";
            // 
            // radioButtonNurse
            // 
            this.radioButtonNurse.AutoSize = true;
            this.radioButtonNurse.Location = new System.Drawing.Point(202, 21);
            this.radioButtonNurse.Name = "radioButtonNurse";
            this.radioButtonNurse.Size = new System.Drawing.Size(53, 17);
            this.radioButtonNurse.TabIndex = 2;
            this.radioButtonNurse.TabStop = true;
            this.radioButtonNurse.Text = "Nurse";
            this.radioButtonNurse.UseVisualStyleBackColor = true;
            // 
            // radioButtonDoctor
            // 
            this.radioButtonDoctor.AutoSize = true;
            this.radioButtonDoctor.Location = new System.Drawing.Point(41, 21);
            this.radioButtonDoctor.Name = "radioButtonDoctor";
            this.radioButtonDoctor.Size = new System.Drawing.Size(57, 17);
            this.radioButtonDoctor.TabIndex = 1;
            this.radioButtonDoctor.TabStop = true;
            this.radioButtonDoctor.Text = "Doctor";
            this.radioButtonDoctor.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(107, 235);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 15;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(107, 186);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 13;
            this.txtPhone.Tag = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Phone";
            // 
            // txtStreetAddress1
            // 
            this.txtStreetAddress1.Location = new System.Drawing.Point(107, 134);
            this.txtStreetAddress1.Name = "txtStreetAddress1";
            this.txtStreetAddress1.Size = new System.Drawing.Size(148, 20);
            this.txtStreetAddress1.TabIndex = 9;
            this.txtStreetAddress1.Tag = "Street Address 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Street Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "MI";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(107, 82);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(148, 20);
            this.txtLastName.TabIndex = 6;
            this.txtLastName.Tag = "Last Name";
            // 
            // txtMInit
            // 
            this.txtMInit.Location = new System.Drawing.Point(297, 56);
            this.txtMInit.Name = "txtMInit";
            this.txtMInit.Size = new System.Drawing.Size(19, 20);
            this.txtMInit.TabIndex = 5;
            this.txtMInit.Tag = "Middle Initial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(107, 56);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(148, 20);
            this.txtFirstName.TabIndex = 4;
            this.txtFirstName.Tag = "First Name";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(291, 193);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(100, 20);
            this.txtZip.TabIndex = 14;
            this.txtZip.Tag = "Zip";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "Zip";
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDOB.Location = new System.Drawing.Point(297, 83);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(94, 20);
            this.dateTimePickerDOB.TabIndex = 67;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(258, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 68;
            this.label11.Text = "Sex";
            // 
            // cboGender
            // 
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboGender.Location = new System.Drawing.Point(291, 111);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(100, 21);
            this.cboGender.TabIndex = 8;
            this.cboGender.Tag = "Gender";
            // 
            // cboState
            // 
            this.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboState.FormattingEnabled = true;
            this.cboState.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.cboState.Location = new System.Drawing.Point(291, 166);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(121, 21);
            this.cboState.TabIndex = 12;
            this.cboState.Tag = "State";
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 300);
            this.Controls.Add(this.cboState);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateTimePickerDOB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSSN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.radioButtonAdmin);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStreetAddress2);
            this.Controls.Add(this.radioButtonNurse);
            this.Controls.Add(this.radioButtonDoctor);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtStreetAddress1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtMInit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFirstName);
            this.Name = "AddEmployeeForm";
            this.Text = "AddEmployeeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSSN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioButtonAdmin;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStreetAddress2;
        private System.Windows.Forms.RadioButton radioButtonNurse;
        private System.Windows.Forms.RadioButton radioButtonDoctor;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStreetAddress1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtMInit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.ComboBox cboState;
    }
}
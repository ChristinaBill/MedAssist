namespace MedAssist.View
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nurseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newVisitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateVisitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newVisitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.nurseToolStripMenuItem,
            this.acountToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(964, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // nurseToolStripMenuItem
            // 
            this.nurseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updatePatientToolStripMenuItem,
            this.registerPatientToolStripMenuItem,
            this.searchPatientToolStripMenuItem,
            this.newVisitToolStripMenuItem1,
            this.updateVisitToolStripMenuItem});
            this.nurseToolStripMenuItem.Name = "nurseToolStripMenuItem";
            this.nurseToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.nurseToolStripMenuItem.Text = "Nurse";
            // 
            // updatePatientToolStripMenuItem
            // 
            this.updatePatientToolStripMenuItem.Name = "updatePatientToolStripMenuItem";
            this.updatePatientToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.updatePatientToolStripMenuItem.Text = "Update Patient";
            this.updatePatientToolStripMenuItem.Click += new System.EventHandler(this.updatePatientToolStripMenuItem_Click);
            // 
            // registerPatientToolStripMenuItem
            // 
            this.registerPatientToolStripMenuItem.Name = "registerPatientToolStripMenuItem";
            this.registerPatientToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.registerPatientToolStripMenuItem.Text = "Register Patient";
            this.registerPatientToolStripMenuItem.Click += new System.EventHandler(this.registerPatientToolStripMenuItem_Click);
            // 
            // searchPatientToolStripMenuItem
            // 
            this.searchPatientToolStripMenuItem.Name = "searchPatientToolStripMenuItem";
            this.searchPatientToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.searchPatientToolStripMenuItem.Text = "Search Patient";
            this.searchPatientToolStripMenuItem.Click += new System.EventHandler(this.searchPatientToolStripMenuItem_Click);
            // 
            // newVisitToolStripMenuItem1
            // 
            this.newVisitToolStripMenuItem1.Name = "newVisitToolStripMenuItem1";
            this.newVisitToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.newVisitToolStripMenuItem1.Text = "New Visit";
            this.newVisitToolStripMenuItem1.Click += new System.EventHandler(this.newVisitToolStripMenuItem1_Click_1);
            // 
            // updateVisitToolStripMenuItem
            // 
            this.updateVisitToolStripMenuItem.Name = "updateVisitToolStripMenuItem";
            this.updateVisitToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.updateVisitToolStripMenuItem.Text = "Update Visit";
            this.updateVisitToolStripMenuItem.Click += new System.EventHandler(this.updateVisitToolStripMenuItem_Click);
            // 
            // acountToolStripMenuItem
            // 
            this.acountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.acountToolStripMenuItem.Name = "acountToolStripMenuItem";
            this.acountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.acountToolStripMenuItem.Text = "Account";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click_1);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportsToolStripMenuItem,
            this.updateEmployeeToolStripMenuItem,
            this.addEmployeeToolStripMenuItem,
            this.addTestToolStripMenuItem,
            this.updateTestToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // updateEmployeeToolStripMenuItem
            // 
            this.updateEmployeeToolStripMenuItem.Name = "updateEmployeeToolStripMenuItem";
            this.updateEmployeeToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.updateEmployeeToolStripMenuItem.Text = "Update Employee";
            this.updateEmployeeToolStripMenuItem.Click += new System.EventHandler(this.updateEmployeeToolStripMenuItem_Click);
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.addEmployeeToolStripMenuItem.Text = "Add Employee";
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addEmployeeToolStripMenuItem_Click);
            // 
            // addTestToolStripMenuItem
            // 
            this.addTestToolStripMenuItem.Name = "addTestToolStripMenuItem";
            this.addTestToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.addTestToolStripMenuItem.Text = "Add Test";
            this.addTestToolStripMenuItem.Click += new System.EventHandler(this.addTestToolStripMenuItem_Click);
            // 
            // updateTestToolStripMenuItem
            // 
            this.updateTestToolStripMenuItem.Name = "updateTestToolStripMenuItem";
            this.updateTestToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.updateTestToolStripMenuItem.Text = "Update Test";
            this.updateTestToolStripMenuItem.Click += new System.EventHandler(this.updateTestToolStripMenuItem_Click_1);
            // 
            // newVisitToolStripMenuItem
            // 
            this.newVisitToolStripMenuItem.Name = "newVisitToolStripMenuItem";
            this.newVisitToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.newVisitToolStripMenuItem.Text = "New Visit";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 536);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nurseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatePatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newVisitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newVisitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateVisitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateTestToolStripMenuItem;
    }
}
namespace MedAssist.View
{
    partial class UpdateTestForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTestID = new System.Windows.Forms.TextBox();
            this.btnGetTestID = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTestName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test ID";
            // 
            // txtTestID
            // 
            this.txtTestID.Location = new System.Drawing.Point(60, 14);
            this.txtTestID.Name = "txtTestID";
            this.txtTestID.Size = new System.Drawing.Size(208, 20);
            this.txtTestID.TabIndex = 1;
            this.txtTestID.Tag = "Test ID";
            this.txtTestID.TextChanged += new System.EventHandler(this.txtTestID_TextChanged);
            // 
            // btnGetTestID
            // 
            this.btnGetTestID.Location = new System.Drawing.Point(281, 12);
            this.btnGetTestID.Name = "btnGetTestID";
            this.btnGetTestID.Size = new System.Drawing.Size(75, 23);
            this.btnGetTestID.TabIndex = 2;
            this.btnGetTestID.Text = "Get Test";
            this.btnGetTestID.UseVisualStyleBackColor = true;
            this.btnGetTestID.Click += new System.EventHandler(this.btnGetTestID_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Test Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTestName
            // 
            this.txtTestName.Location = new System.Drawing.Point(77, 71);
            this.txtTestName.Name = "txtTestName";
            this.txtTestName.Size = new System.Drawing.Size(191, 20);
            this.txtTestName.TabIndex = 3;
            this.txtTestName.Tag = "Test Name";
            this.txtTestName.TextChanged += new System.EventHandler(this.txtTestName_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(193, 132);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(274, 132);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ckBox
            // 
            this.ckBox.AutoSize = true;
            this.ckBox.Location = new System.Drawing.Point(77, 136);
            this.ckBox.Name = "ckBox";
            this.ckBox.Size = new System.Drawing.Size(59, 17);
            this.ckBox.TabIndex = 4;
            this.ckBox.Tag = "Enabled";
            this.ckBox.Text = "Enable";
            this.ckBox.UseVisualStyleBackColor = true;
            // 
            // UpdateTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 178);
            this.Controls.Add(this.ckBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtTestName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGetTestID);
            this.Controls.Add(this.txtTestID);
            this.Controls.Add(this.label1);
            this.Name = "UpdateTestForm";
            this.Text = "Update Test Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTestID;
        private System.Windows.Forms.Button btnGetTestID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTestName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox ckBox;
    }
}
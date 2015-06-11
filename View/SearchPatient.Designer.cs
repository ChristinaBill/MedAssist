namespace MedAssist.View
{
    partial class SearchPatient
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchPatient));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.patientVisitSearchBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.patientVisitSearchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsAndVisits = new MedAssist.PatientsAndVisits();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.patientVisitSearchBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.patientVisitSearchDataGridView = new System.Windows.Forms.DataGridView();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsAndAllVisitInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsAndAllVisitInfo = new MedAssist.PatientsAndAllVisitInfo();
            this.lblDateFormat = new System.Windows.Forms.Label();
            this.patientVisitSearchTableAdapter = new MedAssist.PatientsAndVisitsTableAdapters.PatientVisitSearchTableAdapter();
            this.tableAdapterManager = new MedAssist.PatientsAndVisitsTableAdapters.TableAdapterManager();
            this.patientsTableAdapter = new MedAssist.PatientsAndAllVisitInfoTableAdapters.PatientsTableAdapter();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mInitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.systolicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diastolicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperatureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.respirationRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heartRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.symptomsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diagnosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitSearchBindingNavigator)).BeginInit();
            this.patientVisitSearchBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitSearchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsAndVisits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitSearchDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsAndAllVisitInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsAndAllVisitInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(449, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(839, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DOB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(75, 39);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(157, 20);
            this.txtFName.TabIndex = 3;
            this.txtFName.Tag = "First Name";
            this.txtFName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 4;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(513, 39);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(157, 20);
            this.txtLName.TabIndex = 5;
            this.txtLName.Tag = "Last Name";
            this.txtLName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(875, 39);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(157, 20);
            this.txtDOB.TabIndex = 6;
            this.txtDOB.Tag = "Date of Birth";
            this.txtDOB.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(928, 387);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1090, 387);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1009, 387);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "New Patient";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // patientVisitSearchBindingNavigator
            // 
            this.patientVisitSearchBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.patientVisitSearchBindingNavigator.BindingSource = this.patientVisitSearchBindingSource;
            this.patientVisitSearchBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.patientVisitSearchBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.patientVisitSearchBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.patientVisitSearchBindingNavigatorSaveItem});
            this.patientVisitSearchBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.patientVisitSearchBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.patientVisitSearchBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.patientVisitSearchBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.patientVisitSearchBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.patientVisitSearchBindingNavigator.Name = "patientVisitSearchBindingNavigator";
            this.patientVisitSearchBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.patientVisitSearchBindingNavigator.Size = new System.Drawing.Size(1175, 25);
            this.patientVisitSearchBindingNavigator.TabIndex = 11;
            this.patientVisitSearchBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // patientVisitSearchBindingSource
            // 
            this.patientVisitSearchBindingSource.DataMember = "PatientVisitSearch";
            this.patientVisitSearchBindingSource.DataSource = this.patientsAndVisits;
            // 
            // patientsAndVisits
            // 
            this.patientsAndVisits.DataSetName = "PatientsAndVisits";
            this.patientsAndVisits.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // patientVisitSearchBindingNavigatorSaveItem
            // 
            this.patientVisitSearchBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.patientVisitSearchBindingNavigatorSaveItem.Enabled = false;
            this.patientVisitSearchBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("patientVisitSearchBindingNavigatorSaveItem.Image")));
            this.patientVisitSearchBindingNavigatorSaveItem.Name = "patientVisitSearchBindingNavigatorSaveItem";
            this.patientVisitSearchBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.patientVisitSearchBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // patientVisitSearchDataGridView
            // 
            this.patientVisitSearchDataGridView.AllowUserToAddRows = false;
            this.patientVisitSearchDataGridView.AllowUserToDeleteRows = false;
            this.patientVisitSearchDataGridView.AutoGenerateColumns = false;
            this.patientVisitSearchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientVisitSearchDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.mInitDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.DOB,
            this.visitDateDataGridViewTextBoxColumn,
            this.systolicDataGridViewTextBoxColumn,
            this.diastolicDataGridViewTextBoxColumn,
            this.temperatureDataGridViewTextBoxColumn,
            this.respirationRateDataGridViewTextBoxColumn,
            this.heartRateDataGridViewTextBoxColumn,
            this.symptomsDataGridViewTextBoxColumn,
            this.TestName,
            this.Result,
            this.Diagnosis});
            this.patientVisitSearchDataGridView.DataSource = this.patientVisitSearchBindingSource;
            this.patientVisitSearchDataGridView.Location = new System.Drawing.Point(12, 76);
            this.patientVisitSearchDataGridView.Name = "patientVisitSearchDataGridView";
            this.patientVisitSearchDataGridView.ReadOnly = true;
            this.patientVisitSearchDataGridView.Size = new System.Drawing.Size(1155, 297);
            this.patientVisitSearchDataGridView.TabIndex = 11;
            this.patientVisitSearchDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientVisitSearchDataGridView_CellContentClick);
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.patientsAndAllVisitInfoBindingSource;
            // 
            // patientsAndAllVisitInfoBindingSource
            // 
            this.patientsAndAllVisitInfoBindingSource.DataSource = this.patientsAndAllVisitInfo;
            this.patientsAndAllVisitInfoBindingSource.Position = 0;
            // 
            // patientsAndAllVisitInfo
            // 
            this.patientsAndAllVisitInfo.DataSetName = "PatientsAndAllVisitInfo";
            this.patientsAndAllVisitInfo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblDateFormat
            // 
            this.lblDateFormat.AutoSize = true;
            this.lblDateFormat.ForeColor = System.Drawing.Color.Red;
            this.lblDateFormat.Location = new System.Drawing.Point(1039, 42);
            this.lblDateFormat.Name = "lblDateFormat";
            this.lblDateFormat.Size = new System.Drawing.Size(61, 13);
            this.lblDateFormat.TabIndex = 12;
            this.lblDateFormat.Text = "yyyy-mm-dd";
            // 
            // patientVisitSearchTableAdapter
            // 
            this.patientVisitSearchTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = MedAssist.PatientsAndVisitsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mInitDataGridViewTextBoxColumn
            // 
            this.mInitDataGridViewTextBoxColumn.DataPropertyName = "MInit";
            this.mInitDataGridViewTextBoxColumn.HeaderText = "MInit";
            this.mInitDataGridViewTextBoxColumn.Name = "mInitDataGridViewTextBoxColumn";
            this.mInitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DOB
            // 
            this.DOB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DOB.DataPropertyName = "DOB";
            this.DOB.HeaderText = "DOB";
            this.DOB.Name = "DOB";
            this.DOB.ReadOnly = true;
            this.DOB.Width = 55;
            // 
            // visitDateDataGridViewTextBoxColumn
            // 
            this.visitDateDataGridViewTextBoxColumn.DataPropertyName = "VisitDate";
            this.visitDateDataGridViewTextBoxColumn.HeaderText = "VisitDate";
            this.visitDateDataGridViewTextBoxColumn.Name = "visitDateDataGridViewTextBoxColumn";
            this.visitDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // systolicDataGridViewTextBoxColumn
            // 
            this.systolicDataGridViewTextBoxColumn.DataPropertyName = "Systolic";
            this.systolicDataGridViewTextBoxColumn.HeaderText = "Systolic";
            this.systolicDataGridViewTextBoxColumn.Name = "systolicDataGridViewTextBoxColumn";
            this.systolicDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diastolicDataGridViewTextBoxColumn
            // 
            this.diastolicDataGridViewTextBoxColumn.DataPropertyName = "Diastolic";
            this.diastolicDataGridViewTextBoxColumn.HeaderText = "Diastolic";
            this.diastolicDataGridViewTextBoxColumn.Name = "diastolicDataGridViewTextBoxColumn";
            this.diastolicDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // temperatureDataGridViewTextBoxColumn
            // 
            this.temperatureDataGridViewTextBoxColumn.DataPropertyName = "Temperature";
            this.temperatureDataGridViewTextBoxColumn.HeaderText = "Temperature";
            this.temperatureDataGridViewTextBoxColumn.Name = "temperatureDataGridViewTextBoxColumn";
            this.temperatureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // respirationRateDataGridViewTextBoxColumn
            // 
            this.respirationRateDataGridViewTextBoxColumn.DataPropertyName = "RespirationRate";
            this.respirationRateDataGridViewTextBoxColumn.HeaderText = "RespirationRate";
            this.respirationRateDataGridViewTextBoxColumn.Name = "respirationRateDataGridViewTextBoxColumn";
            this.respirationRateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // heartRateDataGridViewTextBoxColumn
            // 
            this.heartRateDataGridViewTextBoxColumn.DataPropertyName = "HeartRate";
            this.heartRateDataGridViewTextBoxColumn.HeaderText = "HeartRate";
            this.heartRateDataGridViewTextBoxColumn.Name = "heartRateDataGridViewTextBoxColumn";
            this.heartRateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // symptomsDataGridViewTextBoxColumn
            // 
            this.symptomsDataGridViewTextBoxColumn.DataPropertyName = "Symptoms";
            this.symptomsDataGridViewTextBoxColumn.HeaderText = "Symptoms";
            this.symptomsDataGridViewTextBoxColumn.Name = "symptomsDataGridViewTextBoxColumn";
            this.symptomsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TestName
            // 
            this.TestName.DataPropertyName = "TestName";
            this.TestName.HeaderText = "Test Name";
            this.TestName.Name = "TestName";
            this.TestName.ReadOnly = true;
            // 
            // Result
            // 
            this.Result.DataPropertyName = "Result";
            this.Result.HeaderText = "Result";
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            // 
            // Diagnosis
            // 
            this.Diagnosis.DataPropertyName = "Diagnosis";
            this.Diagnosis.HeaderText = "Diagnosis";
            this.Diagnosis.Name = "Diagnosis";
            this.Diagnosis.ReadOnly = true;
            // 
            // SearchPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 422);
            this.Controls.Add(this.lblDateFormat);
            this.Controls.Add(this.patientVisitSearchDataGridView);
            this.Controls.Add(this.patientVisitSearchBindingNavigator);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SearchPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Search";
            this.Load += new System.EventHandler(this.SearchPatientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitSearchBindingNavigator)).EndInit();
            this.patientVisitSearchBindingNavigator.ResumeLayout(false);
            this.patientVisitSearchBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitSearchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsAndVisits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitSearchDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsAndAllVisitInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsAndAllVisitInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClose;
       // private PatientsAndVisitsTableAdapters.VisitsTableAdapter visitsTableAdapter;
        private System.Windows.Forms.Button button3;
        private PatientsAndVisits patientsAndVisits;
        private System.Windows.Forms.BindingSource patientVisitSearchBindingSource;
        private PatientsAndVisitsTableAdapters.PatientVisitSearchTableAdapter patientVisitSearchTableAdapter;
        private PatientsAndVisitsTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator patientVisitSearchBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton patientVisitSearchBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView patientVisitSearchDataGridView;
        private System.Windows.Forms.Label lblDateFormat;
        private System.Windows.Forms.BindingSource patientsAndAllVisitInfoBindingSource;
        private PatientsAndAllVisitInfo patientsAndAllVisitInfo;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private PatientsAndAllVisitInfoTableAdapters.PatientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mInitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn systolicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diastolicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperatureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn respirationRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heartRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn symptomsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diagnosis;
    }
}
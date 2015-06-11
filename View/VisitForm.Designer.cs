namespace MedAssist.View
{
    partial class VisitForm
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
            System.Windows.Forms.Label nurseIDLabel;
            System.Windows.Forms.Label patientNameLabel;
            System.Windows.Forms.Label doctorNameLabel;
            System.Windows.Forms.Label testNameLabel;
            System.Windows.Forms.Label diagnosisLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitForm));
            this.txtNurse = new System.Windows.Forms.TextBox();
            this.txtRespRate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiastolic = new System.Windows.Forms.TextBox();
            this.txtSymptoms = new System.Windows.Forms.TextBox();
            this.txtHeartRate = new System.Windows.Forms.TextBox();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSystolic = new System.Windows.Forms.TextBox();
            this.txtBoxDiagnosis = new System.Windows.Forms.TextBox();
            this.btnOrderTest = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.doctor_Patient_Nurse_Employee_Visit_Dataset = new MedAssist.Doctor_Patient_Nurse_Employee_Visit_Dataset();
            this.visitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visitsTableAdapter = new MedAssist.Doctor_Patient_Nurse_Employee_Visit_DatasetTableAdapters.VisitsTableAdapter();
            this.tableAdapterManager = new MedAssist.Doctor_Patient_Nurse_Employee_Visit_DatasetTableAdapters.TableAdapterManager();
            this.visitsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.visitsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cmbPatient = new System.Windows.Forms.ComboBox();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.btnSubmitVitals = new System.Windows.Forms.Button();
            this.testsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddTest = new System.Windows.Forms.Button();
            this.dgvTests = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTest = new System.Windows.Forms.ComboBox();
            this.testsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet = new MedAssist.TestDataSet();
            this.testBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.testsTableAdapter = new MedAssist.TestDataSetTableAdapters.TestsTableAdapter();
            this.tableAdapterManager1 = new MedAssist.TestDataSetTableAdapters.TableAdapterManager();
            nurseIDLabel = new System.Windows.Forms.Label();
            patientNameLabel = new System.Windows.Forms.Label();
            doctorNameLabel = new System.Windows.Forms.Label();
            testNameLabel = new System.Windows.Forms.Label();
            diagnosisLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.doctor_Patient_Nurse_Employee_Visit_Dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitsBindingNavigator)).BeginInit();
            this.visitsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTests)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // nurseIDLabel
            // 
            nurseIDLabel.AutoSize = true;
            nurseIDLabel.Location = new System.Drawing.Point(16, 52);
            nurseIDLabel.Name = "nurseIDLabel";
            nurseIDLabel.Size = new System.Drawing.Size(38, 13);
            nurseIDLabel.TabIndex = 5;
            nurseIDLabel.Text = "Nurse:";
            // 
            // patientNameLabel
            // 
            patientNameLabel.AutoSize = true;
            patientNameLabel.Location = new System.Drawing.Point(16, 78);
            patientNameLabel.Name = "patientNameLabel";
            patientNameLabel.Size = new System.Drawing.Size(43, 13);
            patientNameLabel.TabIndex = 39;
            patientNameLabel.Text = "Patient:";
            // 
            // doctorNameLabel
            // 
            doctorNameLabel.AutoSize = true;
            doctorNameLabel.Location = new System.Drawing.Point(16, 26);
            doctorNameLabel.Name = "doctorNameLabel";
            doctorNameLabel.Size = new System.Drawing.Size(42, 13);
            doctorNameLabel.TabIndex = 40;
            doctorNameLabel.Text = "Doctor:";
            // 
            // testNameLabel
            // 
            testNameLabel.AutoSize = true;
            testNameLabel.Location = new System.Drawing.Point(27, 34);
            testNameLabel.Name = "testNameLabel";
            testNameLabel.Size = new System.Drawing.Size(31, 13);
            testNameLabel.TabIndex = 41;
            testNameLabel.Text = "Test:";
            // 
            // diagnosisLabel
            // 
            diagnosisLabel.AutoSize = true;
            diagnosisLabel.Location = new System.Drawing.Point(380, 40);
            diagnosisLabel.Name = "diagnosisLabel";
            diagnosisLabel.Size = new System.Drawing.Size(56, 13);
            diagnosisLabel.TabIndex = 30;
            diagnosisLabel.Text = "Diagnosis:";
            // 
            // txtNurse
            // 
            this.txtNurse.Enabled = false;
            this.txtNurse.Location = new System.Drawing.Point(74, 49);
            this.txtNurse.Name = "txtNurse";
            this.txtNurse.Size = new System.Drawing.Size(219, 20);
            this.txtNurse.TabIndex = 2;
            // 
            // txtRespRate
            // 
            this.txtRespRate.Location = new System.Drawing.Point(118, 121);
            this.txtRespRate.Name = "txtRespRate";
            this.txtRespRate.Size = new System.Drawing.Size(198, 20);
            this.txtRespRate.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Respitory Rate:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(217, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "D";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "S";
            // 
            // txtDiastolic
            // 
            this.txtDiastolic.Location = new System.Drawing.Point(238, 22);
            this.txtDiastolic.Name = "txtDiastolic";
            this.txtDiastolic.Size = new System.Drawing.Size(56, 20);
            this.txtDiastolic.TabIndex = 5;
            // 
            // txtSymptoms
            // 
            this.txtSymptoms.Location = new System.Drawing.Point(118, 163);
            this.txtSymptoms.Multiline = true;
            this.txtSymptoms.Name = "txtSymptoms";
            this.txtSymptoms.Size = new System.Drawing.Size(198, 124);
            this.txtSymptoms.TabIndex = 24;
            // 
            // txtHeartRate
            // 
            this.txtHeartRate.Location = new System.Drawing.Point(118, 88);
            this.txtHeartRate.Name = "txtHeartRate";
            this.txtHeartRate.Size = new System.Drawing.Size(198, 20);
            this.txtHeartRate.TabIndex = 23;
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(118, 56);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(198, 20);
            this.txtTemp.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Symptoms:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Body Temp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Heart Rate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Blood Pressure:";
            // 
            // txtSystolic
            // 
            this.txtSystolic.Location = new System.Drawing.Point(144, 22);
            this.txtSystolic.Name = "txtSystolic";
            this.txtSystolic.Size = new System.Drawing.Size(56, 20);
            this.txtSystolic.TabIndex = 4;
            // 
            // txtBoxDiagnosis
            // 
            this.txtBoxDiagnosis.Location = new System.Drawing.Point(442, 37);
            this.txtBoxDiagnosis.Multiline = true;
            this.txtBoxDiagnosis.Name = "txtBoxDiagnosis";
            this.txtBoxDiagnosis.Size = new System.Drawing.Size(240, 170);
            this.txtBoxDiagnosis.TabIndex = 31;
            // 
            // btnOrderTest
            // 
            this.btnOrderTest.Location = new System.Drawing.Point(30, 278);
            this.btnOrderTest.Name = "btnOrderTest";
            this.btnOrderTest.Size = new System.Drawing.Size(108, 23);
            this.btnOrderTest.TabIndex = 33;
            this.btnOrderTest.Text = "Order";
            this.btnOrderTest.UseVisualStyleBackColor = true;
            this.btnOrderTest.Click += new System.EventHandler(this.btnOrderTest_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(442, 536);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(108, 23);
            this.btnSubmit.TabIndex = 37;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(574, 536);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 23);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // doctor_Patient_Nurse_Employee_Visit_Dataset
            // 
            this.doctor_Patient_Nurse_Employee_Visit_Dataset.DataSetName = "Doctor_Patient_Nurse_Employee_Visit_Dataset";
            this.doctor_Patient_Nurse_Employee_Visit_Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visitsBindingSource
            // 
            this.visitsBindingSource.DataMember = "Visits";
            this.visitsBindingSource.DataSource = this.doctor_Patient_Nurse_Employee_Visit_Dataset;
            // 
            // visitsTableAdapter
            // 
            this.visitsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.NursesTableAdapter = null;
            this.tableAdapterManager.PatientsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MedAssist.Doctor_Patient_Nurse_Employee_Visit_DatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // visitsBindingNavigator
            // 
            this.visitsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.visitsBindingNavigator.BindingSource = this.visitsBindingSource;
            this.visitsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.visitsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.visitsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.visitsBindingNavigatorSaveItem});
            this.visitsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.visitsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.visitsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.visitsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.visitsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.visitsBindingNavigator.Name = "visitsBindingNavigator";
            this.visitsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.visitsBindingNavigator.Size = new System.Drawing.Size(731, 25);
            this.visitsBindingNavigator.TabIndex = 39;
            this.visitsBindingNavigator.Text = "bindingNavigator1";
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
            // visitsBindingNavigatorSaveItem
            // 
            this.visitsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.visitsBindingNavigatorSaveItem.Enabled = false;
            this.visitsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("visitsBindingNavigatorSaveItem.Image")));
            this.visitsBindingNavigatorSaveItem.Name = "visitsBindingNavigatorSaveItem";
            this.visitsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.visitsBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // cmbPatient
            // 
            this.cmbPatient.DataSource = this.visitsBindingSource;
            this.cmbPatient.DisplayMember = "PatientName";
            this.cmbPatient.FormattingEnabled = true;
            this.cmbPatient.Location = new System.Drawing.Point(74, 75);
            this.cmbPatient.Name = "cmbPatient";
            this.cmbPatient.Size = new System.Drawing.Size(219, 21);
            this.cmbPatient.TabIndex = 3;
            this.cmbPatient.ValueMember = "PatientID";
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.DataSource = this.visitsBindingSource;
            this.cmbDoctor.DisplayMember = "DoctorName";
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(74, 22);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(219, 21);
            this.cmbDoctor.TabIndex = 1;
            this.cmbDoctor.ValueMember = "DoctorID";
            // 
            // btnSubmitVitals
            // 
            this.btnSubmitVitals.Location = new System.Drawing.Point(119, 305);
            this.btnSubmitVitals.Name = "btnSubmitVitals";
            this.btnSubmitVitals.Size = new System.Drawing.Size(135, 22);
            this.btnSubmitVitals.TabIndex = 41;
            this.btnSubmitVitals.Text = "Submit Vitals/Participants";
            this.btnSubmitVitals.UseVisualStyleBackColor = true;
            this.btnSubmitVitals.Click += new System.EventHandler(this.btnSubmitVitals_Click);
            // 
            // testsBindingSource
            // 
            this.testsBindingSource.DataMember = "Tests";
            // 
            // btnAddTest
            // 
            this.btnAddTest.Location = new System.Drawing.Point(162, 61);
            this.btnAddTest.Name = "btnAddTest";
            this.btnAddTest.Size = new System.Drawing.Size(108, 23);
            this.btnAddTest.TabIndex = 43;
            this.btnAddTest.Text = "Add";
            this.btnAddTest.UseVisualStyleBackColor = true;
            this.btnAddTest.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvTests
            // 
            this.dgvTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTests.Location = new System.Drawing.Point(30, 90);
            this.dgvTests.Name = "dgvTests";
            this.dgvTests.ReadOnly = true;
            this.dgvTests.Size = new System.Drawing.Size(242, 182);
            this.dgvTests.TabIndex = 43;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(164, 278);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 23);
            this.btnClear.TabIndex = 44;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTest);
            this.groupBox1.Controls.Add(this.dgvTests);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnOrderTest);
            this.groupBox1.Controls.Add(this.btnAddTest);
            this.groupBox1.Controls.Add(testNameLabel);
            this.groupBox1.Location = new System.Drawing.Point(410, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 321);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Tests";
            // 
            // cmbTest
            // 
            this.cmbTest.DataSource = this.testsBindingSource1;
            this.cmbTest.DisplayMember = "TestName";
            this.cmbTest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTest.FormattingEnabled = true;
            this.cmbTest.Location = new System.Drawing.Point(64, 30);
            this.cmbTest.Name = "cmbTest";
            this.cmbTest.Size = new System.Drawing.Size(206, 21);
            this.cmbTest.TabIndex = 45;
            this.cmbTest.ValueMember = "TestID";
            // 
            // testsBindingSource1
            // 
            this.testsBindingSource1.DataMember = "Tests";
            this.testsBindingSource1.DataSource = this.testDataSet;
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "TestDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSymptoms);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnSubmitVitals);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTemp);
            this.groupBox2.Controls.Add(this.txtHeartRate);
            this.groupBox2.Controls.Add(this.txtDiastolic);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtRespRate);
            this.groupBox2.Controls.Add(this.txtSystolic);
            this.groupBox2.Location = new System.Drawing.Point(29, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 343);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Routine Checks";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNurse);
            this.groupBox3.Controls.Add(nurseIDLabel);
            this.groupBox3.Controls.Add(this.cmbPatient);
            this.groupBox3.Controls.Add(doctorNameLabel);
            this.groupBox3.Controls.Add(patientNameLabel);
            this.groupBox3.Controls.Add(this.cmbDoctor);
            this.groupBox3.Location = new System.Drawing.Point(29, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(316, 123);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Participants";
            // 
            // testsTableAdapter
            // 
            this.testsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.TestsTableAdapter = this.testsTableAdapter;
            this.tableAdapterManager1.UpdateOrder = MedAssist.TestDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // VisitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 580);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.visitsBindingNavigator);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtBoxDiagnosis);
            this.Controls.Add(diagnosisLabel);
            this.Name = "VisitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "VisitForm";
            this.Load += new System.EventHandler(this.VisitForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctor_Patient_Nurse_Employee_Visit_Dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitsBindingNavigator)).EndInit();
            this.visitsBindingNavigator.ResumeLayout(false);
            this.visitsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTests)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNurse;
        private System.Windows.Forms.TextBox txtRespRate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiastolic;
        private System.Windows.Forms.TextBox txtSymptoms;
        private System.Windows.Forms.TextBox txtHeartRate;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSystolic;
        private System.Windows.Forms.TextBox txtBoxDiagnosis;
        private System.Windows.Forms.Button btnOrderTest;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private Doctor_Patient_Nurse_Employee_Visit_Dataset doctor_Patient_Nurse_Employee_Visit_Dataset;
        private System.Windows.Forms.BindingSource visitsBindingSource;
        private Doctor_Patient_Nurse_Employee_Visit_DatasetTableAdapters.VisitsTableAdapter visitsTableAdapter;
        private Doctor_Patient_Nurse_Employee_Visit_DatasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator visitsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton visitsBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox cmbPatient;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.Button btnSubmitVitals;
        private System.Windows.Forms.BindingSource testsBindingSource;
        private System.Windows.Forms.Button btnAddTest;
        private System.Windows.Forms.DataGridView dgvTests;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.BindingSource testBindingSource;
        private TestDataSet testDataSet;
        private System.Windows.Forms.BindingSource testsBindingSource1;
        private TestDataSetTableAdapters.TestsTableAdapter testsTableAdapter;
        private TestDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ComboBox cmbTest;
    }
}
namespace MedAssist.View
{
    partial class ReportForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.patientDetailedDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patient_Report_Dataset = new MedAssist.Patient_Report_Dataset();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.patientDetailedDataTableAdapter = new MedAssist.Patient_Report_DatasetTableAdapters.PatientDetailedDataTableAdapter();
            this.patientReportDatasetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientDetailedDataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.patientDetailedDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patient_Report_Dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientReportDatasetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDetailedDataBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // patientDetailedDataBindingSource
            // 
            this.patientDetailedDataBindingSource.DataMember = "PatientDetailedData";
            this.patientDetailedDataBindingSource.DataSource = this.patient_Report_Dataset;
            // 
            // patient_Report_Dataset
            // 
            this.patient_Report_Dataset.DataSetName = "Patient_Report_Dataset";
            this.patient_Report_Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "PatientDetailedData";
            reportDataSource1.Value = this.patientDetailedDataBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MedAssist.View.PatientDetailedReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 62);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1460, 554);
            this.reportViewer1.TabIndex = 0;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CustomFormat = "yyyy-mm-dd";
            this.dateTimePickerStart.Location = new System.Drawing.Point(456, 21);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStart.TabIndex = 1;
            this.dateTimePickerStart.Value = new System.DateTime(2014, 12, 12, 0, 0, 0, 0);
            this.dateTimePickerStart.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.CustomFormat = "yyyy-mm-dd";
            this.dateTimePickerEnd.Location = new System.Drawing.Point(736, 21);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEnd.TabIndex = 2;
            this.dateTimePickerEnd.Value = new System.DateTime(2015, 5, 5, 0, 0, 0, 0);
            this.dateTimePickerEnd.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(417, 27);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(33, 13);
            this.lblFrom.TabIndex = 3;
            this.lblFrom.Text = "From:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(707, 27);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(23, 13);
            this.lblTo.TabIndex = 4;
            this.lblTo.Text = "To:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(973, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // patientDetailedDataTableAdapter
            // 
            this.patientDetailedDataTableAdapter.ClearBeforeFill = true;
            // 
            // patientReportDatasetBindingSource
            // 
            this.patientReportDatasetBindingSource.DataSource = this.patient_Report_Dataset;
            this.patientReportDatasetBindingSource.Position = 0;
            // 
            // patientDetailedDataBindingSource1
            // 
            this.patientDetailedDataBindingSource1.DataMember = "PatientDetailedData";
            this.patientDetailedDataBindingSource1.DataSource = this.patient_Report_Dataset;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 616);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportForm";
            this.Text = "Patient Visit Report";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientDetailedDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patient_Report_Dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientReportDatasetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDetailedDataBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.BindingSource patientDetailedDataBindingSource;
        private Patient_Report_Dataset patient_Report_Dataset;
        private Patient_Report_DatasetTableAdapters.PatientDetailedDataTableAdapter patientDetailedDataTableAdapter;
        private System.Windows.Forms.BindingSource patientReportDatasetBindingSource;
        private System.Windows.Forms.BindingSource patientDetailedDataBindingSource1;
    }
}
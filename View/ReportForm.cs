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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
 
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// search button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
           DateTime vs = this.dateTimePickerStart.Value;
           DateTime ve = this.dateTimePickerEnd.Value;
           this.patientDetailedDataTableAdapter.Fill(patient_Report_Dataset.PatientDetailedData, vs, ve);
           this.reportViewer1.RefreshReport();
        }
    }
}

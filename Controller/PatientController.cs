using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedAssist.DAL;
using MedAssist.Model;

namespace MedAssist.Controller
{
    class PatientController
    {
        public PatientController() { }

        /// <summary>
        /// Returns a list of Patients
        /// </summary>
        /// <returns>The list of Patients</returns>
        public List<Patient> GetPatientList()
        {
            return PatientDAL.GetPatientList();
        }

        /// <summary>
        /// Gets the visit and patient information using first name and last name
        /// </summary>
        /// <param name="fName">first name</param>
        /// <param name="lName">last name</param>
        /// <returns>list of patients</returns>
        public static List<Patient> GetVisitForPatient(string fName, string lName) {
            
            return PatientDAL.GetVisitForPatient(fName, lName);
        }

        /// <summary>
        /// Gets the visit and patient information using DOB
        /// </summary>
        /// <param name="patientDob">DOB</param>
        /// <returns>patient list</returns>
        public static List<Patient> GetPatientsByDOB(DateTime patientDob)
        {
            return PatientDAL.GetPatientsByDOB(patientDob);
        }

        /// <summary>
        /// Gets the visit and patient information using DOB and last name
        /// </summary>
        /// <param name="lName">last name</param>
        /// <param name="patientDob">dob</param>
        /// <returns>list of patients</returns>
        public static List<Patient> GetVisitForPatientWithDobAndLName(string lName, DateTime patientDob)
        {
            return PatientDAL.GetVisitForPatientWithDobAndLName(lName, patientDob);
        }

        /// <summary>
        /// Creates a patient
        /// </summary>
        /// <param name="patient">patient</param>
        /// <returns>the patient id added</returns>
        public static int CreatePatient(Patient patient)
        {
            return PatientDAL.AddPatient(patient);
        }

        /// <summary>
        /// Gets a patient using patientID
        /// </summary>
        /// <param name="patientID">patientID</param>
        /// <returns>Patient</returns>
        public static Patient GetPatientWithID(int patientID)
        {
            return PatientDAL.GetPatientWithID(patientID);
        }
    }
}

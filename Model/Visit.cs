using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedAssist.Model
{
    class Visit
    {
        private int visitID;
        private DateTime visitDate;
        private int nurseID;
        private int patientID;
        private int doctorID;
        private string diagnosis;
        private int systolic;
        private int diastolic;
        private decimal temp;
        private int respRate;
        private int heartRate;
        private string symptoms;

        //added by greene
        private DateTime dOB;
        private string lastName;
        private string firstName;
        private string mInit;
        private string result;
        private int testID;
        private string testName;


        public Visit() { }

        public int VisitID
        {
            get
            {
                return visitID;
            }
            set
            {
                visitID = value;
            }
        }

        public DateTime VisitDate
        {
            get
            {
                return visitDate;
            }
            set
            {
                visitDate = value;
            }
        }

        public int NurseID
        {
            get
            {
                return nurseID;
            }
            set
            {
                nurseID = value;
            }
        }

        public int PatientID
        {
            get
            {
                return patientID;
            }
            set
            {
                patientID = value;
            }
        }

        public int DoctorID
        {
            get
            {
                return doctorID;
            }
            set
            {
                doctorID = value;
            }
        }

        public string Diagnosis
        {
            get
            {
                return diagnosis;
            }
            set
            {
                diagnosis = value;
            }
        }

        public int Systolic
        {
            get
            {
                return systolic;
            }
            set
            {
                systolic = value;
            }
        }

        public int Diastolic
        {
            get
            {
                return diastolic;
            }
            set
            {
                diastolic = value;
            }
        }

        public decimal Temperature
        {
            get
            {
                return temp;
            }
            set
            {
                temp = value;
            }
        }

        public int RespirationRate
        {
            get
            {
                return respRate;
            }
            set
            {
                respRate = value;
            }
        }

        public int HeartRate
        {
            get
            {
                return heartRate;
            }
            set
            {
                heartRate = value;
            }
        }

        public string Symptoms
        {
            get
            {
                return symptoms;
            }
            set
            {
                symptoms = value;
            }
        }

        public DateTime DOB
        {
            get
            {
                return dOB;
            }
            set
            {
                dOB = value;
            }
        }

        public String LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public String FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public String MInit
        {
            get
            {
                return mInit;
            }
            set
            {
                mInit = value;
            }
        }
        
        public String Result
        {
            get
            {
                return result;
            }
            set
            {
                result = value;
            }
        }

        public String TestName
        {
            get
            {
                return testName;
            }
            set
            {
                testName = value;
            }
        }

        public int TestID
        {
            get
            {
                return testID;
            }
            set
            {
                testID = value;
            }
        }

        public string visitDateID
        {
            get
            {
                string date = VisitDate.ToString("MM/dd/yyyy");
                return ("Visit Date: " + date + "     " + "Visit ID: " + VisitID);
            }
        }
    }
}

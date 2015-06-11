using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedAssist.Model
{
    class Patient
    {
        private int patientID;
        private string ssn;
        private string fName;
        private string mInit;
        private string lName;
        private DateTime dob;
        private char? gender;
        private string street1;
        private string street2;
        private string city;
        private string phone;
        private string state;
        private string zip;

        private int? visitID;
        private DateTime visitDate;
        private int? systolic;
        private int? diastolic;
        private decimal? temperature;
        private int? respirationRate;
        private int? heartRate;
        private string symptoms;
        private int? testID;
        private string testName;
        private string diagnosis;
        private string result;

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

        public string SSN
        {
            get
            {
                return ssn;
            }
            set
            {
                ssn = value;
            }
        }

        public string FirstName
        {
            get
            {
                return fName;
            }
            set
            {
                fName = value;
            }
        }

        public string MInit
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

        public string LastName
        {
            get
            {
                return lName;
            }
            set
            {
                lName = value;
            }
        }

        public DateTime DOB
        {
            get
            {
                return dob;
            }
            set
            {
                dob = value;
            }
        }

        public char? Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }

        public string StreetAddr1
        {
            get
            {
                return street1;
            }
            set
            {
                street1 = value;
            }
        }

        public string StreetAddr2
        {
            get
            {
                return street2;
            }
            set
            {
                street2 = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }

        public string ZipCode
        {
            get
            {
                return zip;
            }
            set
            {
                zip = value;
            }
        }

        public string State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }

        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }

        public int? VisitID
        {
            get;

            set;

        }

        public DateTime? VisitDate
        {
            get;

            set;
            
        }

        public int? Systolic
        {
            get;
            
            set;
         
        }

        public int? Diastolic
        {
            get;

            set;
        }
            
        public decimal? Temperature
        {
            get;
            
            set;
           
        }

        public int? RespirationRate
        {
            get;

            set;

        }
        
        public int? HeartRate
        {
            get;

            set;

        }
        
        public string Symptoms
        {
            get;

            set;

        }
        
        public int? TestID
        {
            get;

            set;

        }
        
        public string TestName
        {
            get;

            set;

        }
        
        public string Diagnosis
        {
            get;
            
            set;
           
        }

        public string Result
        {
            get;

            set;


        }
    }
}


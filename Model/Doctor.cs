using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedAssist.Model
{
    class Doctor
    {
        private int doctorID;
        private string userName;

        public Doctor() { }

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

        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
            }
        }
    }
}

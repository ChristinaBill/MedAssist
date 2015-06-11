using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedAssist.Model
{
      class Nurse
    {
        private int nurseID;
        private string userName;
        private string password;

        public Nurse() { }

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

        public String Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
    }
}

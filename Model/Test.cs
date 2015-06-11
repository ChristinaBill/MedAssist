using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MedAssist.Model
{
    class Test : INotifyPropertyChanged
    {
        private int testID;
        private string testName;
        private bool inactive;

        public event PropertyChangedEventHandler PropertyChanged;

        public Test() { }

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

        // this was DoctorID. Changed by Greene. 
        public string TestName
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

        public bool Inactive
        {
            get
            {
                return inactive;
            }
            set
            {
                inactive = value;
            }
        }

        private void NotifyPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }

        
 
}

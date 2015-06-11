using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedAssist.Model;

namespace MedAssist.Controller
{
    /// <summary>
    /// Static class that tracks the current patient
    /// </summary>
    static class CurrentPatientController
    {
        public static Patient currentPatient;
        static Patient _currentPatient;
        public static Patient CurrentPatient
        {
            get
            {
                return _currentPatient;
            }
            set
            {
                _currentPatient = value;
            }
        }
    }
}

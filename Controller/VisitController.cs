using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedAssist.DAL;
using MedAssist.Model;

namespace MedAssist.Controller
{
    /// <summary>
    /// Connects the View and the VisitDAL
    /// </summary>
    class VisitController
    {
        public VisitController() {}

        /// <summary>
        /// Inserts a visit into the Visit Table
        /// </summary>
        /// <param name="visit">The Visit to enter into the table</param>
        /// <returns>The visit ID that was inserted</returns>
        public static int CreateVisit(Visit visit)
        {
            VisitDAL visitDAL = new VisitDAL();
            return visitDAL.createVisit(visit);
        }

        /// <summary>
        /// Updates the diagnosis
        /// </summary>
        /// <param name="visit">new visit</param>
        /// <param name="oldVisit">old visit</param>
        /// <returns>true if successful</returns>
        public static bool UpdateDiagnosis(Visit visit, Visit oldVisit)
        {
            return VisitDAL.UpdateDiagnosis(visit, oldVisit);
        }
    }
}

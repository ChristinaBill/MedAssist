using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedAssist.DAL;
using MedAssist.Model;

namespace MedAssist.Controller
{
    class ControllerAdmin
    {
        /// <summary>
        /// Gets and Administrator object
        /// </summary>
        /// <param name="userName">username</param>
        /// <param name="password">password</param>
        /// <returns>Administrator</returns>
        public Administrator GetAdmin(string userName, string password)
        {
            return AdminDAL.GetAdmin(userName, password);
        }
    }
}

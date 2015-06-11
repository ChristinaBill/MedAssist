using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedAssist.Model;
using MedAssist.DAL;

namespace MedAssist.Controller
{
    /// <summary>
    /// Static class that holds login information for the application
    /// </summary>
    static class UserSecurityController
    {
        public static Nurse NurseLoggedIn = null;

        public static Administrator AdminLoggedIn = null;

        /// <summary>
        /// Updates the password
        /// </summary>
        /// <param name="oldUser">old password</param>
        /// <param name="newUser">new password</param>
        /// <returns>true if successful</returns>
        public static bool UpdatePassword(UserSecurity oldUser, UserSecurity newUser)
        {
            return UserSecurityDAL.UpdatePassword(oldUser, newUser);
        }
    }

   
}

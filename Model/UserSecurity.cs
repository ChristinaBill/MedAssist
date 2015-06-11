using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedAssist.Model
{
    class UserSecurity
    {
        private string userName;
        private string password;

        public UserSecurity() { }

        public String UserName 
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

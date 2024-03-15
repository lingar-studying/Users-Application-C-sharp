using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users_Application_C_sharp.Users
{
    public class RegularUser : BaseUser
    {
        public RegularUser()
        {
            this.userType = UserType.REGULAR_USER;


            //this.userType2 = "Rgular user";
            //this = null;
        }
    }
}

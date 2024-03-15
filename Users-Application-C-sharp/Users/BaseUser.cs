using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users_Application_C_sharp.Users
{

    /**
 * Not for direct using!
 * */
    public abstract class BaseUser
    {

        protected static int idGenerator = -1;
        protected UserType userType;

        protected string userType2 ;

        private readonly int id;
        private string userName = "";
        private string email = "";
        private string password = "";

    }
}

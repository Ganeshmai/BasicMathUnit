using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMathUnit
{
   
    public class Reservation
    {
        public User Madeby { get; set; }

        public bool CanbeCancelledBy(User user)
        {
            if (user.IsAdmin)
                return true;
            if(Madeby== user)
                return true;
            return false;
        }

    }
    public class User {
        public bool IsAdmin { get; set; }
    }

}


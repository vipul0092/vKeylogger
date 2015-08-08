using System;
using System.Collections.Generic;
using System.Text;

namespace vKeyLogger.Authorise
{
    public partial class AuthProg
    {
        string pass;

        public AuthProg()
        {
            this.pass = "punisher";
        }

        bool checkAuth(string password)
        {
            if (password == this.pass)
                return true;
            else
                return false;
        }

    }
}

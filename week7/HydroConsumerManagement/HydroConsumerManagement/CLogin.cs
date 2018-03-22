using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HydroConsumerManagement
{
    class CLogin : IComparable
    {
        private String username;
        private String password;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            CLogin otherCLogin = obj as CLogin;
            if (otherCLogin != null)
                return this.username.CompareTo(otherCLogin.username);
            else
                throw new ArgumentException("Object is not a username");
        }
    }
}

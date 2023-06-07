using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.BL
{
    class User
    {
        private string UserName;
        private string Password;
        private string Role;
        public User(string UserName, string Password, string Role)
        {
            this.UserName = UserName;
            this.Password = Password;
            this.Role = Role;
        }
        public User(string UserName, string Password)
        {
            this.UserName = UserName;
            this.Password = Password;
            
        }
        public string GetUserName()
        {
            return UserName;
        }
        public string GetPassword()
        {
            return Password;
        }
        public string GetRole()
        {
            return Role;
        }

    }
}

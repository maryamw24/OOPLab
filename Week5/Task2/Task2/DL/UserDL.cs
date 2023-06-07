using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.BL;

namespace Task2.DL
{
    class UserDL
    {
        public static List<User> UsersList = new List<User>();
        public static void AddUserToList(User u)
        {
            UsersList.Add(u);
        }
        public static User SignIn(U)
        {
            foreach (User i in UsersList)
            {
                if (info.GetUserName() == i.GetUserName() && info.GetPassword() == i.GetPassword()) ;
                {
                    return i;
                }
            }
            return null;
        }

    }
}

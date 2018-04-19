using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopManagement.DAL.DAO;
using ShopManagement.DAL.GateWay;

namespace ShopManagement.BLL
{
    public class UserManager
    {
        private UserDataAccess userDataAccess;
        private User user;

        public UserManager()
        {
            userDataAccess= new UserDataAccess();
        }
        public User ValidateUser(string name, string password)
        {
            return userDataAccess.ValidateUser(name, password);
        }

        public int RequestSave(User user)
        {
            this.user = user;
            if (userDataAccess.HasThisUserReq(user.UserName))
            {
                return -1;
            }
            else
            {
                if (userDataAccess.HasThisUserName(user.UserName))
                {
                    return -1;
                }
                else
                {
                    return userDataAccess.RequestSave(user);
                }
            }
        }

        public bool HasRequest()
        {
            return userDataAccess.HasRequest();
        }

        public List<User> GetAllRequests()
        {
            return userDataAccess.GetAllRequests();
        }
        public List<User> GetAllUsers()
        {
            return userDataAccess.GetAllUsers();
        }

        public bool DeleteRequest(User user)
        {
            int delete = userDataAccess.DeleteRequest(user);
            if (delete > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AcceptRequest(User user)
        {
            int accept = userDataAccess.AcceptRequest(user);
            int delete = userDataAccess.DeleteRequest(user);
            if (accept > 0 && delete > 0)
            {
                return true;
            }
            return false;
        }

        public int DeleteUser(string uName)
        {
            if (userDataAccess.HasThisUserName(uName))
            {
                return userDataAccess.DeleteUser(uName);
            }
            else
            {
                return -1;
            }
        }

        public int EditInfo(User user)
        {
            if (!userDataAccess.IsPasswordMatch(user.UserName,user.Password))
            {
                return -1;
            }
            else
            {
                return userDataAccess.EditInformation(user);
            }
        }

        public int EditPassword(User user)
        {
            return userDataAccess.ChangePassword(user.UserName, user.Password);
        }

        public int RecoverPassword(User user)
        {
            if (!userDataAccess.IsInfoMatch(user))
            {
                return -1;
            }
            else
            {
                return userDataAccess.RecoverPass(user.UserName, user.Password);
            }
        }
    }
}

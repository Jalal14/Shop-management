using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ShopManagement.DAL.DAO;

namespace ShopManagement.DAL.GateWay
{
    public class UserDataAccess : DataAccess
    {
        private SqlDataReader reader;
        private User user;

        public User ValidateUser(string uName, string pass)
        {
            string query = string.Format("select * from users where userName='{0}' and password='{1}'",uName,pass);
            command = new SqlCommand(query, connection);
            command.Connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                User.Gender gender;
                User.Role role;
                if (reader.GetInt32(9) == 0)
                {
                    gender = User.Gender.male;
                }
                else
                {
                    gender = User.Gender.female;
                }
                if (reader.GetInt32(10) == 0)
                {
                    role = User.Role.manager;
                }
                else if (reader.GetInt32(10) == 1)
                {
                    role = User.Role.admin;
                }
                else
                {
                    role = User.Role.salesman;
                }
                user = new User(reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetDateTime(4),
                    reader.GetString(5),
                    reader.GetString(6),
                    reader.GetString(7),
                    reader.GetString(8),
                    gender,
                    role);
                command.Connection.Close();
                return user;
            }
            command.Connection.Close();
            return null;
        }
        public bool HasThisUserName(string uName)
        {
            string query = string.Format("select userName from users where userName='{0}'", uName);
            return base.QueryOperation(query);
        }

        public bool HasThisUserReq(string uName)
        {
            string query = string.Format("select userName from request where userName='{0}'", uName);
            return base.QueryOperation(query);
        }

        public bool HasRequest()
        {
            string query = "select id from request";
            return base.QueryOperation(query);
        }

        public bool IsPasswordMatch(string uName, string password)
        {
            string query = string.Format("select id from users where username='{0}' and password='{1}'", uName, password);
            return base.QueryOperation(query);
        }

        public bool IsInfoMatch(User user)
        {
            int gender;
            if (user.Gender1==User.Gender.male)
            {
                gender = 0;
            }
            else
            {
                gender = 1;
            }
            string query =
                string.Format(
                    "select id from users where firstname='{0}' and lastname='{1}' and username='{2}' and DOB='{3}' and email='{4}' and sequrityQues='{5}' and secureAns='{6}' and gender={7}",
                    user.FirstName, user.LastName, user.UserName, user.DOb.ToString("MM-dd-yyyy"), user.Email, user.SequrityQuestion,
                    user.SecureAnswer, gender);
            return base.QueryOperation(query);
        }

        public int RequestSave(User user)
        {
            int role;
            int gender;
            if (user.Gender1==User.Gender.male)
            {
                gender = 0;
            }
            else
            {
                gender = 1;
            }
            if (user.Role1==User.Role.admin)
            {
                role = 1;
            }
            else
            {
                role = 2;
            }

            string query =
                string.Format(
                    "insert into request (firstname,lastname,username,DOB,email,sequrityQues,secureAns,password,gender,role) values " +
                    "('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}',{8},{9})",
                    user.FirstName,
                    user.LastName,
                    user.UserName,
                    user.DOb.ToString("MM-dd-yyyy"),
                    user.Email,
                    user.SequrityQuestion,
                    user.SecureAnswer,
                    user.Password,
                    gender,
                    role);
            return base.NonQueryOperation(query);
        }

        public int AcceptRequest(User user)
        {
            int gender;
            int role;
            if (user.Gender1==User.Gender.male)
            {
                gender = 0;
            }
            else
            {
                gender = 1;
            }
            if (user.Role1==User.Role.admin)
            {
                role = 1;
            }
            else
            {
                role = 2;
            }
            string query=string.Format("insert into users (firstName,lastName,userName,DOB,email,sequrityQues,secureAns,password,gender,role) values " +
                    "('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}',{8},{9})",
                    user.FirstName,
                    user.LastName,
                    user.UserName,
                    user.DOb,
                    user.Email,
                    user.SequrityQuestion,
                    user.SecureAnswer,
                    user.Password,
                    gender,
                    role);
            return base.NonQueryOperation(query);
        }

        public int DeleteRequest(User user)
        {
            string query = string.Format("delete from request where userName='{0}'", user.UserName);
            return base.NonQueryOperation(query);
        }

        public int DeleteUser(string uName)
        {
            string query = string.Format("delete from users where userName='{0}'", uName);
            return base.NonQueryOperation(query);
        }

        public int EditInformation(User user)
        {
            int gender;
            if (user.Gender1==User.Gender.male)
            {
                gender = 0;
            }
            else
            {
                gender = 1;
            }
            string query =
                string.Format(
                    "update users set firstName='{0}',lastName='{1}',DOB='{2}',email='{3}',sequrityQues='{4}',secureAns='{5}',gender={6} where username='{7}'",
                    user.FirstName,
                    user.LastName,
                    user.DOb,
                    user.Email,
                    user.SequrityQuestion,
                    user.SecureAnswer,
                    gender,
                    user.UserName);
            return base.NonQueryOperation(query);
        }

        public int RecoverPass(string userName, string pass)
        {
            string query = string.Format("update users set password='{0}' where username='{1}'",
                pass, userName);
            return base.NonQueryOperation(query);
        }

        public int ChangePassword(string user, string pass)
        {
            string query = string.Format("update users set password='{0}' where username='{1}'", pass, user);
            return base.NonQueryOperation(query);
        }
        private List<User> GetAll(string query)
        {
            List<User> users=new List<User>();
            command = new SqlCommand(query, connection);
            command.Connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                User.Gender gender;
                User.Role role;
                if (reader.GetInt32(9) == 0)
                {
                    gender = User.Gender.male;
                }
                else
                {
                    gender = User.Gender.female;
                }
                if (reader.GetInt32(10) == 1)
                {
                    role = User.Role.admin;
                }
                else
                {
                    role = User.Role.salesman;
                }
                User user = new User(reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetDateTime(4),
                    reader.GetString(5),
                    reader.GetString(6),
                    reader.GetString(7),
                    reader.GetString(8),
                    gender, role);
                users.Add(user);
            }
            command.Connection.Close();
            return users;
        }

        public List<User> GetAllUsers()
        {
            string query = "select * from users where role=1 or role=2";
            return this.GetAll(query);
        }

        public List<User> GetAllRequests()
        {
            string query = "select * from request";
            return this.GetAll(query);
        }
    }
}

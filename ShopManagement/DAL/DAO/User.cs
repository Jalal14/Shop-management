using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagement.DAL.DAO
{
    public class User
    {
        private string firstName;
        private string lastName;
        private string userName;
        private DateTime dOB;
        private string email;
        private string sequrityQuestion;
        private string secureAnswer;
        private string password;
        private Gender gender;
        private Role role;
        public enum Gender
        {
            male,
            female
        };

        public enum Role
        {
            manager,
            admin,
            salesman
        };
        
        public User(string firstName, string lastName, string userName,DateTime dOB, string email, string ques, string ans, string password, Gender gender,Role role)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.userName = userName;
            this.dOB = dOB;
            this.email = email;
            this.sequrityQuestion = ques;
            this.secureAnswer = ans;
            this.password = password;
            this.gender = gender;
            this.role = role;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public DateTime DOb
        {
            get { return dOB; }
            set { dOB = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string SequrityQuestion
        {
            get { return sequrityQuestion; }
            set { sequrityQuestion = value; }
        }

        public string SecureAnswer
        {
            get { return secureAnswer; }
            set { secureAnswer = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public Gender Gender1
        {
            get { return gender; }
            set { gender = value; }
        }

        public Role Role1
        {
            get { return role; }
            set { role = value; }
        }
    }
}

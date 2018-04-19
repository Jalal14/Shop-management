using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using ShopManagement.BLL;
using ShopManagement.DAL.DAO;

namespace ShopManagement.GUI
{
    public partial class PasswordRecoverForm : MetroForm
    {
        private LoginForm loginForm;
        private UserManager userManager;
        public PasswordRecoverForm()
        {
            InitializeComponent();
        }

        public PasswordRecoverForm(LoginForm loginForm):this()
        {
            userManager=new UserManager();
            this.loginForm = loginForm;
        }

        private void submitMetroButton_Click(object sender, EventArgs e)
        {
            List<string> fields = new List<string>
            {
                firstNameTextBox.Text,
                lastNameTextBox.Text,
                userNameTextBox.Text,
                emailTextBox.Text,
                sequrityQuestionTextBox.Text,
                secureAnswerTextBox.Text,
                newPasswordTextBox.Text,
                confirmPasswordTextBox.Text
            };
            if (fields.Contains("") || (!maleRadioButton.Checked && !femaleRadioButton.Checked))
            {
                MessageBox.Show("Fill all fields properly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!emailTextBox.Text.Contains("@") || !emailTextBox.Text.Contains(".com"))
            {
                MessageBox.Show("Invalid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!newPasswordTextBox.Text.Equals(confirmPasswordTextBox.Text))
            {
                MessageBox.Show("Password not matched", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Confirm submission", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    User user = CreateUser();
                    try
                    {
                        if (userManager.RecoverPassword(user) == -1)
                        {
                            MessageBox.Show("Wrong information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {

                            MessageBox.Show("Password changed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loginForm.Show();
                            this.Dispose();
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Error occurd during loading database", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void resetMetroButton_Click(object sender, EventArgs e)
        {
            ResetInformationField();
        }


        private void backMetroButton_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Dispose();
        }
        private void ResetInformationField()
        {
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            userNameTextBox.Text = "";
            emailTextBox.Text = "";
            sequrityQuestionTextBox.Text = "";
            secureAnswerTextBox.Text = "";
            newPasswordTextBox.Text = "";
            confirmPasswordTextBox.Text = "";
        }

        public User CreateUser()
        {
            User.Gender gender;
            if (maleRadioButton.Checked)
            {
                gender = User.Gender.male;
            }
            else
            {
                gender = User.Gender.female;
            }
            User user = new User(firstNameTextBox.Text,
                lastNameTextBox.Text,
                userNameTextBox.Text,
                dOBMetroDateTime.Value,
                emailTextBox.Text,
                sequrityQuestionTextBox.Text,
                secureAnswerTextBox.Text,
                newPasswordTextBox.Text,
                gender,
                User.Role.salesman);
            return user;
        }
    }
}

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
    public partial class EditInformationForm : MetroForm
    {
        private UserManager userManager;
        private Form informationForm;
        private User currentUser;
        public EditInformationForm()
        {
            InitializeComponent();
        }
        public EditInformationForm(Form form, User currentUser): this()
        {
            this.informationForm = form;
            this.currentUser = currentUser;
            this.userManager=new UserManager();
        }

        private void EditInformationForm_Load(object sender, EventArgs e)
        {
            LoadInformationField();
        }

        private void submitMetroButton_Click(object sender, EventArgs e)
        {
            List<string> fields = new List<string>
            {
                firstNameTextBox.Text,
                lastNameTextBox.Text,
                emailTextBox.Text,
                sequrityQuestionTextBox.Text,
                secureAnswerTextBox.Text,
                passwordTextBox.Text,
                passwordTextBox.Text,
                confirmPasswordTextBox.Text
            };
            if (fields.Contains("") || (!maleRadioButton.Checked && !femaleRadioButton.Checked))
            {
                MessageBox.Show("Fill all fields properly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!passwordTextBox.Text.Equals(confirmPasswordTextBox.Text))
            {
                MessageBox.Show("Password not matched", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                User newUser = this.CreateNewUser();
                try
                {
                    if (userManager.EditInfo(newUser) == -1)
                    {
                        MessageBox.Show("Wrong password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Information saved", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.currentUser = newUser;
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error occured during loading database", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                this.LoadInformationField();
            }
        }

        private void changePassMetroButton_Click(object sender, EventArgs e)
        {
            new ChangePasswordForm(currentUser).Show();
        }

        private void resetMetroButton_Click(object sender, EventArgs e)
        {
            ResetInformationField();
        }

        private void backMetroButton_Click(object sender, EventArgs e)
        {
            if (currentUser.Role1==User.Role.manager)
            {
                new ManagerForm(currentUser).Show();
            }
            else if (currentUser.Role1==User.Role.admin)
            {
                new AdminForm(currentUser).Show();
            }
            else
            {
                new SalesmanForm(currentUser).Show();
            }
            this.Dispose();
        }
        private void LoadInformationField()
        {
            firstNameTextBox.Text = currentUser.FirstName;
            lastNameTextBox.Text = currentUser.LastName;
            dOBMetroDateTime.Value = currentUser.DOb;
            emailTextBox.Text = currentUser.Email;
            sequrityQuestionTextBox.Text = currentUser.SequrityQuestion;
            secureAnswerTextBox.Text = currentUser.SecureAnswer;
            if (currentUser.Gender1 == User.Gender.male)
            {
                maleRadioButton.Checked = true;
            }
            else
            {
                femaleRadioButton.Checked = true;
            }
            passwordTextBox.Clear();
            confirmPasswordTextBox.Clear();
        }

        private void ResetInformationField()
        {
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            emailTextBox.Clear();
            sequrityQuestionTextBox.Clear();
            secureAnswerTextBox.Clear();
            passwordTextBox.Clear();
            confirmPasswordTextBox.Clear();
        }

        private User CreateNewUser()
        {
            User.Gender gender;
            if (maleRadioButton.Checked)
            {
                gender=User.Gender.male;
            }
            else
            {
                gender=User.Gender.female;
            }
            User newUser = new User(firstNameTextBox.Text,
                lastNameTextBox.Text,
                currentUser.UserName,
                dOBMetroDateTime.Value,
                emailTextBox.Text,
                sequrityQuestionTextBox.Text,
                secureAnswerTextBox.Text,
                passwordTextBox.Text,
                gender,
                currentUser.Role1);

            return newUser;
        }
    }
}

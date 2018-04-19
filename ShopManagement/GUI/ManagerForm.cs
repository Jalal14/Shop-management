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
using ShopManagement.GUI;

namespace ShopManagement.GUI
{
    public partial class ManagerForm : MetroForm
    {
        private User user,currentUser;
        private UserManager userManager;
        private ItemManager itemManager;
        private int limitedStock = 10;
        public ManagerForm()
        {
            InitializeComponent();
            userManager=new UserManager();
        }

        public ManagerForm(User user)
            : this()
        {
            this.currentUser = user;
            itemManager = new ItemManager();
        }

        private void logoutMetroButton_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Dispose();
        }
        
        private void editInfoMetroButton_Click(object sender, EventArgs e)
        {
            new EditInformationForm(this,this.currentUser).Show();
            this.Hide();
        }
        private void resetMetroButton_Click(object sender, EventArgs e)
        {
            this.ResetSignUpField();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            if (!itemManager.HasWarning(limitedStock))
            {
                warningLabel.Hide();
            }
            else
            {
                warningLabel.Show();
            }
        }
        private void transactionMetroButton_Click(object sender, EventArgs e)
        {
            new TransactionForm().Show();
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
                passwordTextBox.Text,
                confirmPasswordTextBox.Text
            };
            if (!passwordTextBox.Text.Equals(confirmPasswordTextBox.Text))
            {
                MessageBox.Show("Password not matched", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((!maleMetroRadioButton.Checked && !femaleMetroRadioButton.Checked) || fields.Contains(""))
            {
                MessageBox.Show("Fill all field properly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!adminMetroRadioButton.Checked && !salesmanMetroRadioButton.Checked)
            {
                MessageBox.Show("Usertype not selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!emailTextBox.Text.Contains("@") || !emailTextBox.Text.Contains(".com"))
            {
                MessageBox.Show("Invalid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.CreateUserProfile();
                try
                {
                    int save = userManager.RequestSave(this.user);
                    if (save==-1)
                    {
                        MessageBox.Show("Username already taken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        this.ResetSignUpField();
                        MessageBox.Show("Submitted");
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error occured during loading database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void resetMetroButtonDelete_Click(object sender, EventArgs e)
        {
            this.ResetDeleteField();
        }

        private void submitMetroButtonDelete_Click(object sender, EventArgs e)
        {
            List<string> fields = new List<string>
            {
                salesmanNameTextBoxDelete.Text,
                managerPasswordTextBox.Text,
                confirmManagerPasswordTextBox.Text
            };
            if (!managerPasswordTextBox.Text.Equals(confirmManagerPasswordTextBox.Text))
            {
                MessageBox.Show("Password not matched", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (fields.Contains(""))
            {
                MessageBox.Show("Fill all field properly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!managerPasswordTextBox.Text.Equals(currentUser.Password))
            {
                MessageBox.Show("Incorrect password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result =
                   MessageBox.Show("You are about to delete " + salesmanNameTextBoxDelete.Text + " \nIs that alright?",
                                   "Delete Salesman", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (userManager.DeleteUser(salesmanNameTextBoxDelete.Text) == -1)
                        {
                            this.ResetDeleteField();
                            MessageBox.Show("User not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            this.ResetDeleteField();
                            this.LoadListView();
                            MessageBox.Show("Deleted user : " + salesmanNameTextBoxDelete.Text, "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Error occured during loading database", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void showAllMetroButton_Click(object sender, EventArgs e)
        {
            this.LoadListView();
        }

        private void ResetSignUpField()
        {
            this.firstNameTextBox.Clear();
            this.lastNameTextBox.Clear();
            this.userNameTextBox.Clear();
            this.emailTextBox.Clear();
            this.sequrityQuestionTextBox.Clear();
            this.secureAnswerTextBox.Clear();
            this.passwordTextBox.Clear();
            this.confirmPasswordTextBox.Clear();
        }
        private void ResetDeleteField()
        {
            this.salesmanNameTextBoxDelete.Clear();
            this.managerPasswordTextBox.Clear();
            this.confirmManagerPasswordTextBox.Clear();
        }

        private void CreateUserProfile()
        {
            User.Gender gender;
            User.Role role;
            if (maleMetroRadioButton.Checked)
            {
                gender = User.Gender.male;
            }
            else
            {
                gender = User.Gender.female;
            }
            if (adminMetroRadioButton.Checked)
            {
                role=User.Role.admin;
            }
            else
            {
                role=User.Role.salesman;
            }
            user = new User(firstNameTextBox.Text,
                    lastNameTextBox.Text,
                    userNameTextBox.Text,
                    dOBMetroDateTime.Value,
                    emailTextBox.Text,
                    sequrityQuestionTextBox.Text,
                    secureAnswerTextBox.Text,
                    passwordTextBox.Text,
                    gender,
                    role);
        }

        private void LoadListView()
        {
            userListMetroListView.Items.Clear();
            List<User> users;
            try
            {
                int slNo = 1;
                users = userManager.GetAllUsers();
                foreach (User user in users)
                {
                    ListViewItem item = new ListViewItem(slNo.ToString());
                    item.Tag = user;
                    item.SubItems.Add(user.UserName);
                    item.SubItems.Add(user.Role1.ToString());
                    userListMetroListView.Items.Add(item);
                    slNo++;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error occurd during loading database", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void warningLabel_Click(object sender, EventArgs e)
        {
            new LimitedStockForm(limitedStock).Show();
        }

        private void userListMetroListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            User user = (User) userListMetroListView.SelectedItems[0].Tag;
            salesmanNameTextBoxDelete.Text = user.UserName;
        }
    }
}

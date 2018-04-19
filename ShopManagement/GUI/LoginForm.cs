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
    public partial class LoginForm : MetroForm
    {
        private UserManager userManager;

        public LoginForm()
        {
            InitializeComponent();
            userManager=new UserManager();
        }

        private void loginMetroButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text.Equals("")||passwordTextBox.Text.Equals(""))
            {
                MessageBox.Show("Username and password required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    User user = userManager.ValidateUser(usernameTextBox.Text, passwordTextBox.Text);
                    if (user == null)
                    {
                        this.passwordTextBox.Clear();
                        MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (user.Role1 == User.Role.manager)
                    {
                        this.ResetTextFields();
                        new ManagerForm(user).Show();
                        this.Hide();
                    }
                    else if (user.Role1 == User.Role.admin)
                    {
                        this.ResetTextFields();
                        new AdminForm(user).Show();
                        this.Hide();
                    }
                    else if (user.Role1 == User.Role.salesman)
                    {
                        this.ResetTextFields();
                        new SalesmanForm(user).Show();
                        this.Hide();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error ocured during loading database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void resetMetroButton_Click(object sender, EventArgs e)
        {
            this.ResetTextFields();
        }

        private void forgotPasswordLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.ResetTextFields();
            new PasswordRecoverForm(this).Show();
            this.Hide();
        }

        private void ResetTextFields()
        {
            passwordTextBox.Clear();
            usernameTextBox.Clear();
        }
    }
}

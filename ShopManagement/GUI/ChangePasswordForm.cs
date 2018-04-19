using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
    public partial class ChangePasswordForm : MetroForm
    {
        private User currentUser;
        private UserManager userManager;
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        public ChangePasswordForm(User currentUser) : this()
        {
            this.currentUser = currentUser;
            this.userManager=new UserManager();
        }

        private void submitMetroButton_Click(object sender, EventArgs e)
        {
            if (!newPasswordTextBox.Text.Equals(confirmPasswordTextBox.Text))
            {
                MessageBox.Show("Password not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                User newUser = this.CreateNewUser();
                if (!oldPasswordTextBox.Text.Equals(currentUser.Password))
                {
                    MessageBox.Show("Wrong password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        userManager.EditPassword(newUser);
                        MessageBox.Show("Saved", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.currentUser = newUser;
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Error occured during loading database", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        throw;
                    }
                }
            }
        }

        private void resetMetroButton_Click(object sender, EventArgs e)
        {
            oldPasswordTextBox.Clear();
            newPasswordTextBox.Clear();
            confirmPasswordTextBox.Clear();
        }

        private User CreateNewUser()
        {
            return new User(currentUser.FirstName,
                currentUser.LastName,
                currentUser.UserName,
                currentUser.DOb,
                currentUser.Email,
                currentUser.SequrityQuestion,
                currentUser.SecureAnswer,
                newPasswordTextBox.Text,
                currentUser.Gender1,
                currentUser.Role1);
        }
    }
}

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
    public partial class NotificationForm : MetroForm
    {
        private AdminForm adminForm;
        private UserManager userManager;
        private ListViewItem item;
        public NotificationForm()
        {
            InitializeComponent();
        }

        public NotificationForm(AdminForm adminForm)
            : this()
        {
            userManager=new UserManager();
            this.adminForm = adminForm;
        }

        private void NotificationForm_Load(object sender, EventArgs e)
        {
            this.LoadListView();
            //this.ShowUserInfo((User)item.Tag);
        }

        private void notificationListMetroListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            User user = (User) notificationListMetroListView.SelectedItems[0].Tag;
            ShowUserInfo(user);
        }

        private void acceptMetroButton_Click(object sender, EventArgs e)
        {
            if (item.Tag==null)
            {
                MessageBox.Show("Select user to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.IsEmpty())
            {
                MessageBox.Show("Fill all fields properly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show(
                    string.Format("Assign salesman: \nName: {0} {1}", firstaNameTextBox.Text , lastNameTextBox.Text),
                    "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        User user = (User)item.Tag;
                        bool accepted = this.AcceptUser(user);
                        if (accepted)
                        {
                            MessageBox.Show("Accepted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            item.Tag = null;
                            this.ResetUserInfoField();
                            this.LoadListView();
                        }
                        else
                        {
                            MessageBox.Show("Something wrong", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Error occured during loading database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void rejectMetroButton_Click(object sender, EventArgs e)
        {
            if (item.Tag == null)
            {
                MessageBox.Show("Select user to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.IsEmpty())
            {
                MessageBox.Show("Fill all fields properly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    User user = (User)item.Tag;
                    bool rejected = this.RejectUser(user);
                    if (rejected)
                    {
                        MessageBox.Show("Rejected", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.ResetUserInfoField();
                        this.LoadListView();
                    }
                    else
                    {
                        MessageBox.Show("Something wrong", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    throw;
                }
            }
        }

        private void backMetroButton_Click(object sender, EventArgs e)
        {
            adminForm.ShowNotification();
            adminForm.Show();
            this.Dispose();
        }

        private void LoadListView()
        {
            notificationListMetroListView.Items.Clear();
            List<User> users;
            try
            {
                int slNo = 1;
                users = userManager.GetAllRequests();
                foreach (User user in users)
                {
                    item = new ListViewItem(slNo.ToString());
                    item.Tag = user;
                    item.SubItems.Add(user.Role1.ToString());
                    notificationListMetroListView.Items.Add(item);
                    slNo++;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error occurd during loading database", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ShowUserInfo(User user)
        {
            firstaNameTextBox.Text = user.FirstName;
            lastNameTextBox.Text = user.LastName;
            emailTextBox.Text = user.Email;
            dOBTextBox.Text = user.DOb.ToString("dd-MMMM-yyyy");
            genderTextBox.Text = user.Gender1.ToString();
        }

        private bool AcceptUser(User user)
        {
            return userManager.AcceptRequest(user);
        }

        private bool RejectUser(User user)
        {
            return userManager.DeleteRequest(user);
        }
        private void ResetUserInfoField()
        {
            firstaNameTextBox.Clear();
            lastNameTextBox.Clear();
            emailTextBox.Clear();
            dOBTextBox.Clear();
            genderTextBox.Clear();
        }

        private bool IsEmpty()
        {
            if (firstaNameTextBox.Text.Equals("")||lastNameTextBox.Text.Equals("") || emailTextBox.Text.Equals("") || dOBTextBox.Equals("") || genderTextBox.Text.Equals(""))
            {
                return true;
            }
            return false;
        }
    }
}

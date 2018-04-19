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
    public partial class AdminForm : MetroForm
    {
        private UserManager userManager;
        private ItemManager itemManager;
        private User currentUser;
        private ListViewItem listItem;
        private List<Item> stockItems;
        public AdminForm()
        {
            InitializeComponent();
            userManager = new UserManager();
            itemManager = new ItemManager();
        }

        public AdminForm(User currentUser)
            : this()
        {
            this.currentUser = currentUser;
            try
            {
                stockItems = itemManager.GetAllItems();
            }
            catch (Exception e)
            {
                MessageBox.Show(
                    "Due to error occured during loading database\nAuto suggestion will not work now.\nPlease login again for this service",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            ShowNotification();
            AutoCompleteField();
        }
        private void AutoCompleteField()
        {
            AutoCompleteStringCollection nameCollection = new AutoCompleteStringCollection();
            AutoCompleteStringCollection idCollection = new AutoCompleteStringCollection();
            foreach (Item item in stockItems)
            {
                nameCollection.Add(item.Name);
                idCollection.Add(item.Id.ToString());
            }
            productIdTextBoxSearchAndUpdate.AutoCompleteCustomSource = idCollection;
            productNameTextBoxSearchAndUpdate.AutoCompleteCustomSource = nameCollection;
            productIdTextBoxDelete.AutoCompleteCustomSource = idCollection;
            productNameTextBoxDelete.AutoCompleteCustomSource = nameCollection;
            idTextBoxUpdateQuantity.AutoCompleteCustomSource = idCollection;
            nameTextBoxUpdateQuantity.AutoCompleteCustomSource = nameCollection;
        }

        public void ShowNotification()
        {
            try
            {
                if (userManager.HasRequest())
                {
                    notificationLabel.Show();
                }
                else
                {
                    notificationLabel.Hide();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error occured during loading notification", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void logoutMetroButton_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Dispose();
        }

        private void editInfoMetroButton_Click(object sender, EventArgs e)
        {
            new EditInformationForm(this, currentUser).Show();
            this.Hide();
        }

        private void showAllProductsMetroButton_Click(object sender, EventArgs e)
        {
            LoadListView();
        }

        private void submitMetroButtonAdd_Click(object sender, EventArgs e)
        {
            double p;
            int i;
            List<string> fields = new List<string>
            {
                productIdTextBoxAdd.Text,
                productNameTextBoxAdd.Text,
                totalPriceLabelAdd.Text,
                productPriceTextBoxAdd.Text
            };
            if (productQuantityNumericUpDownAdd.Value <= 0 || fields.Contains(""))
            {
                MessageBox.Show("Fill all fields properly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Int32.TryParse(productIdTextBoxAdd.Text, out i))
            {
                productIdTextBoxAdd.Clear();
                MessageBox.Show("Id field contains numbers only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Double.TryParse(productPriceTextBoxAdd.Text, out p))
            {
                productPriceTextBoxAdd.Clear();
                MessageBox.Show("Price field contains numbers only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Double.TryParse(totalPriceTextBoxAdd.Text, out p))
            {
                totalPriceTextBoxAdd.Clear();
                MessageBox.Show("Price field contains numbers only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Item item = new Item(Convert.ToInt32(productIdTextBoxAdd.Text),
                    productNameTextBoxAdd.Text,
                    Convert.ToDouble(productPriceTextBoxAdd.Text),
                    Convert.ToInt32(productQuantityNumericUpDownAdd.Value));
                double total = Convert.ToDouble(totalPriceTextBoxAdd.Text);
                try
                {
                    int result = itemManager.AddItem(item,total);
                    if (result==-1)
                    {
                        MessageBox.Show("Id already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (result==-2)
                    {
                        MessageBox.Show(String.Format("{0} already exist"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        LoadListView();
                        this.ResetAddFields();
                        MessageBox.Show("Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error occured during adding item in database\nPlease try again",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void resetMetroButtonAdd_Click(object sender, EventArgs e)
        {
            this.ResetAddFields();
        }

        private void searchMetroBtton_Click(object sender, EventArgs e)
        {
            if (productIdTextBoxSearchAndUpdate.Text.Equals("") && productNameTextBoxSearchAndUpdate.Text.Equals(""))
            {
                MessageBox.Show("Product id or name required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!productNameTextBoxSearchAndUpdate.Text.Equals("") && productIdTextBoxSearchAndUpdate.Text.Equals(""))
            {
                try
                {
                    Item searchedItem = itemManager.SearchItemByName(productNameTextBoxSearchAndUpdate.Text);
                    if (searchedItem == null)
                    {
                        MessageBox.Show("Item not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        FillSearcfFiled(searchedItem);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error occured during loading database\nTry again", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    Item searchedItem = itemManager.SearchItemById(Convert.ToInt32(productIdTextBoxSearchAndUpdate.Text));
                    if (searchedItem == null)
                    {
                        MessageBox.Show("Item not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        FillSearcfFiled(searchedItem);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error occured during loading database\nTry again", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void productListMetroListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item item = (Item) productListMetroListView.SelectedItems[0].Tag;
            FillSearcfFiled(item);
            FillDeleteField(item);
            FillUpdateQuantityField(item);
        }

        private void submitMetroButtonSearchAndUpdate_Click(object sender, EventArgs e)
        {
            int i;
            double p;
            List<string> fields = new List<string>
            {
                productIdTextBoxSearchAndUpdate.Text,
                productNameTextBoxSearchAndUpdate.Text,
                productPriceTextBoxSearchAndUpdate.Text
            };
            if (fields.Contains(""))
            {
                MessageBox.Show("Fill all field properly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Int32.TryParse(productIdTextBoxSearchAndUpdate.Text, out i))
            {
                productIdTextBoxSearchAndUpdate.Text = "";
                MessageBox.Show("Id field contain numbers only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Double.TryParse(productPriceTextBoxSearchAndUpdate.Text, out p))
            {
                productPriceTextBoxAdd.Text = "";
                MessageBox.Show("Price field contain numbers only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Item item = new Item(Convert.ToInt32(productIdTextBoxSearchAndUpdate.Text),
                    productNameTextBoxSearchAndUpdate.Text,
                    Convert.ToDouble(productPriceTextBoxSearchAndUpdate.Text),
                    Convert.ToInt32(productQuantityNumericUpDownSearchAndUpdate.Value));
                try
                {
                    int updatedItem = itemManager.UpdateItemById(item);
                    if (updatedItem == -1)
                    {
                        DialogResult result = MessageBox.Show("Id not found\nwant to update by name?", "Confirmation", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);
                        if (result==DialogResult.Yes)
                        {
                            try
                            {
                                int updatedByName = itemManager.UpdateItemByName(item);
                                if (updatedByName == -1)
                                {
                                    MessageBox.Show("Item not found of this name", "Error", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                                }
                                else
                                {
                                    MessageBox.Show(String.Format("Updated Item\nId: {0}\nName: {1}", item.Id, item.Name), "Success", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                                    LoadListView();
                                }
                            }
                            catch (Exception exception)
                            {
                                MessageBox.Show("Error occured during update databse", "Error", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(String.Format("Updated Item\nId: {0}\nName: {1}", item.Id, item.Name), "Success", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                        LoadListView();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error occured during update databse", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
        private void resetMetroButtonSearchAndUpdate_Click(object sender, EventArgs e)
        {
            ResetSearchAndUpdateField();
        }

        private void submitMetroButtonDelete_Click(object sender, EventArgs e)
        {
            int i;
            if (productIdTextBoxDelete.Text.Equals("") || productNameTextBoxDelete.Text.Equals(""))
            {
                MessageBox.Show("Fill all field properly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Int32.TryParse(productIdTextBoxDelete.Text, out i))
            {
                productIdTextBoxDelete.Text = "";
                MessageBox.Show("Id field contain numbers only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show(string.Format("You are about to delete: {0}", productNameTextBoxDelete.Text), "Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (itemManager.DeleteItem(Convert.ToInt32(productIdTextBoxDelete.Text), productNameTextBoxDelete.Text) == -1)
                        {
                            MessageBox.Show("Item not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show(productNameTextBoxDelete.Text + " deleted", "Deleted", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            this.ResetDeleteField();
                            LoadListView();
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Error occured during deleting item from database", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        
        private void resetMetroButtonDelete_Click(object sender, EventArgs e)
        {
            this.ResetDeleteField();
        }
        
        private void submitMetroButtonUpdateQuantity_Click(object sender, EventArgs e)
        {
            int i;
            if (idTextBoxUpdateQuantity.Text.Equals("") || nameTextBoxUpdateQuantity.Text.Equals("") || Convert.ToInt32(numericUpDownUpdateQuantity.Value) <= 0)
            {
                MessageBox.Show("Fill all field properly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Int32.TryParse(idTextBoxUpdateQuantity.Text, out i))
            {
                idTextBoxUpdateQuantity.Text = "";
                MessageBox.Show("Id field contain numbers only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result =
                    MessageBox.Show(string.Format("You are about to update: {0}", nameTextBoxUpdateQuantity.Text),
                        "Update",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        int update = itemManager.UpdateQUantity(Convert.ToInt32(idTextBoxUpdateQuantity.Text),
                            nameTextBoxUpdateQuantity.Text, Convert.ToInt32(numericUpDownUpdateQuantity.Value));
                        if (update == -1)
                        {
                            MessageBox.Show("Item not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (update == -2)
                        {
                            MessageBox.Show("Error occured during update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show(nameTextBoxUpdateQuantity.Text + " updated", "Deleted", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            ResetUpdateQuantityField();
                            LoadListView();
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Error occured during deleting item from database", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void resetMetroButtonUpdateQuantity_Click(object sender, EventArgs e)
        {
            ResetUpdateQuantityField();
        }
        private void notificationLabel_Click(object sender, EventArgs e)
        {
            new NotificationForm(this).Show();
            this.Hide();
        }

        private void ResetAddFields()
        {
            productIdTextBoxAdd.Clear();
            productNameTextBoxAdd.Clear();
            productPriceTextBoxAdd.Clear();
            totalPriceTextBoxAdd.Clear();
            productQuantityNumericUpDownAdd.Value = 0;
        }

        private void ResetSearchAndUpdateField()
        {
            productIdTextBoxSearchAndUpdate.Clear();
            productNameTextBoxSearchAndUpdate.Clear();
            productPriceTextBoxSearchAndUpdate.Clear();
            productQuantityNumericUpDownSearchAndUpdate.Value = 0;
        }

        private void ResetDeleteField()
        {
            productIdTextBoxDelete.Clear();
            productNameTextBoxDelete.Clear();
        }

        private void ResetUpdateQuantityField()
        {
            idTextBoxUpdateQuantity.Clear();
            nameTextBoxUpdateQuantity.Clear();
            numericUpDownUpdateQuantity.Value = 0;
        }

        private void LoadListView()
        {
            productListMetroListView.Items.Clear();
            List<Item> items;
            try
            {
                int slNo = 1;
                items = itemManager.GetAllItems();
                foreach (Item item in items)
                {
                    listItem = new ListViewItem(slNo.ToString());
                    listItem.Tag = item;
                    listItem.SubItems.Add(item.Id.ToString());
                    listItem.SubItems.Add(item.Name);
                    listItem.SubItems.Add(item.Price.ToString());
                    listItem.SubItems.Add(item.Quantity.ToString());
                    productListMetroListView.Items.Add(listItem);
                    slNo++;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error occured during loading listview due to database error", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void FillSearcfFiled(Item item)
        {
            productIdTextBoxSearchAndUpdate.Text = item.Id.ToString();
            productNameTextBoxSearchAndUpdate.Text = item.Name;
            productPriceTextBoxSearchAndUpdate.Text = item.Price.ToString();
            productQuantityNumericUpDownSearchAndUpdate.Value = item.Quantity;
        }
        private void FillDeleteField(Item item)
        {
            productIdTextBoxDelete.Text = item.Id.ToString();
            productNameTextBoxDelete.Text = item.Name;
        }

        private void FillUpdateQuantityField(Item item)
        {
            idTextBoxUpdateQuantity.Text = item.Id.ToString();
            nameTextBoxUpdateQuantity.Text = item.Name;
        }
    }
}

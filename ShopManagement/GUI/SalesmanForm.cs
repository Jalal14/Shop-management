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
    public partial class SalesmanForm : MetroForm
    {
        private ItemManager itemManager;
        private LoginForm loginForm;
        private User currentUser;
        private ListViewItem listItem;
        private List<Item> cartItems;
        private List<Item> stockItems;
        private Item removeItem;
        public SalesmanForm()
        {
            InitializeComponent();
        }

        public SalesmanForm(User currentUser)
            : this()
        {
            this.currentUser = currentUser;
            itemManager = new ItemManager();
            cartItems = new List<Item>();
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

        private void SalesmanForm_Load(object sender, EventArgs e)
        {
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
            nameTextBox.AutoCompleteCustomSource = nameCollection;
            idTextBox.AutoCompleteCustomSource = idCollection;
        }
        private void editInfoMetroButton_Click(object sender, EventArgs e)
        {
            new EditInformationForm(this, currentUser).Show();
            this.Hide();
        }

        private void logoutMetroButton_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Dispose();
        }

        private void showAllMetroButton_Click(object sender, EventArgs e)
        {
            new AllProductsForm(this).Show();
        }

        private void addMetroButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Equals("") && idTextBox.Text.Equals(""))
            {
                MessageBox.Show("Product id or name required", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if (quantityNumericUpDown.Value <= 0)
            {
                MessageBox.Show("Product quantity required", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if (!nameTextBox.Text.Equals("") && idTextBox.Text.Equals(""))
            {
                try
                {
                    Item item = itemManager.SearchItemByName(nameTextBox.Text);
                    if (item == null)
                    {
                        MessageBox.Show("Item not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        int result = AddToCartList(item, Convert.ToInt32(quantityNumericUpDown.Value));
                        if (result == -1)
                        {
                            ResetTextFields();
                            FillCartList();
                        }
                        else
                        {
                            MessageBox.Show(String.Format("Available unit: {0}", result));
                        }
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error occured during loading database", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    Item item = itemManager.SearchItemById(Convert.ToInt32(idTextBox.Text));
                    if (item == null)
                    {
                        MessageBox.Show("Item not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        int result = AddToCartList(item, Convert.ToInt32(quantityNumericUpDown.Value));
                        if (result == -1)
                        {
                            ResetTextFields();
                            FillCartList();
                        }
                        else
                        {
                            MessageBox.Show(String.Format("Available unit: {0}", result));
                        }
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error occured during loading database", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void searchMetroButton_Click(object sender, EventArgs e)
        {
            int i;
            if (nameTextBox.Text.Equals("") && idTextBox.Text.Equals(""))
            {
                MessageBox.Show("Product name or id required", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if (!idTextBox.Text.Equals("") && !int.TryParse(idTextBox.Text, out i))
            {
                MessageBox.Show("Product id contains number only", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if (!nameTextBox.Text.Equals("") && idTextBox.Text.Equals(""))
            {
                try
                {
                    Item item = itemManager.SearchItemByName(nameTextBox.Text);
                    if (item == null)
                    {
                        MessageBox.Show("Item not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        FillProductField(item);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error occured during loading database", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    Item item = itemManager.SearchItemById(Convert.ToInt32(idTextBox.Text));
                    if (item == null)
                    {
                        MessageBox.Show("Item not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        FillProductField(item);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error occured during loading database", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void cartMetroListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            removeItem = (Item) cartMetroListView.SelectedItems[0].Tag;
        }

        private void removeMetroButton_Click(object sender, EventArgs e)
        {
            if (removeItem == null)
            {
                MessageBox.Show("Select item to remove", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cartItems.Remove(removeItem);
                FillCartList();
            }
        }

        private void printMetroButton_Click(object sender, EventArgs e)
        {
            try
            {
                int number = cartItems.Count;
                if (number == 0)
                {
                    MessageBox.Show("No item in cart", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        int success = itemManager.SellItem(cartItems);
                        if (success == number)
                        {
                            MessageBox.Show(String.Format("Total price is: {0}", totalPriceTextBox.Text), "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cartItems.Clear();
                            FillCartList();
                            totalPriceTextBox.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Error occured during updating", "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Error occured during updating database", "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error occured during loading database", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void FillProductField(Item item)
        {
            idTextBox.Text = item.Id.ToString();
            nameTextBox.Text = item.Name;
            priceTextBox.Text = item.Price.ToString();
        }

        public int AddToCartList(Item cartItem, int ordered)
        {
            bool found = false;
            int available = -1;
            foreach (Item item in cartItems)
            {
                if (item.Id == cartItem.Id)
                {
                    found = true;
                    if (cartItem.Quantity >= item.Quantity+ordered)
                    {
                        item.Quantity += ordered;
                    }
                    else
                    {
                        available = cartItem.Quantity - item.Quantity;
                    }
                    break;
                }
            }
            if (found)
            {
                if (available == -1)
                {
                    return -1;
                }
                else
                {
                    return available;
                }
            }
            else
            {
                if (cartItem.Quantity < ordered)
                {
                    return cartItem.Quantity;
                }
                else
                {
                    cartItem.Quantity = ordered;
                    cartItems.Add(cartItem);
                    return -1;
                }
            }
        }

        public void FillCartList()
        {
            double totalPrice = 0;
            cartMetroListView.Items.Clear();
            try
            {
                int slNo = 1;
                foreach (Item cartItem in cartItems)
                {
                    double netTotal = cartItem.Price * cartItem.Quantity;
                    totalPrice += netTotal;
                    listItem = new ListViewItem(slNo.ToString());
                    listItem.Tag = cartItem;
                    listItem.SubItems.Add(cartItem.Id.ToString());
                    listItem.SubItems.Add(cartItem.Name);
                    listItem.SubItems.Add(cartItem.Quantity.ToString());
                    listItem.SubItems.Add(cartItem.Price.ToString());
                    listItem.SubItems.Add(netTotal.ToString());
                    cartMetroListView.Items.Add(listItem);
                    slNo++;
                }
                totalPriceTextBox.Text = totalPrice.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error occured during loading database", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public void ResetTextFields()
        {
            nameTextBox.Clear();
            idTextBox.Clear();
            priceTextBox.Clear();
            quantityNumericUpDown.Value = 0;
        }
    }
}

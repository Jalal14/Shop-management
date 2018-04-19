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
    public partial class AllProductsForm : MetroForm
    {
        private ItemManager itemManager;
        private ListViewItem listItem;
        private SalesmanForm salesmanForm;
        private Item item;
        public AllProductsForm()
        {
            InitializeComponent();
            itemManager = new ItemManager();
        }

        public AllProductsForm(SalesmanForm salesmanForm) : this()
        {
            this.salesmanForm = salesmanForm;
        }
        
        private void AllProductsForm_Load(object sender, EventArgs e)
        {
            LoadListView();
        }
        private void backMetroButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void LoadListView()
        {
            allProductsMetroListView.Items.Clear();
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
                    listItem.SubItems.Add(item.Quantity.ToString());
                    listItem.SubItems.Add(item.Price.ToString());
                    allProductsMetroListView.Items.Add(listItem);
                    slNo++;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error occured during loading database", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void allProductsMetroListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            item = (Item) allProductsMetroListView.SelectedItems[0].Tag;
        }

        private void addMetroButton_Click(object sender, EventArgs e)
        {
            if (item==null)
            {
                MessageBox.Show("Select item to add", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int ordered = Convert.ToInt32(quantityNumericUpDown.Value);
                if (ordered <= 0)
                {
                    MessageBox.Show("Quantity required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int add = salesmanForm.AddToCartList(CreateItem(), ordered);
                    if (add == -1)
                    {
                        salesmanForm.FillCartList();
                        quantityNumericUpDown.Value = 0;
                    }
                    else
                    {
                        MessageBox.Show(String.Format("Available {0} unit", add), "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        public Item CreateItem()
        {
            return  new Item(this.item.Id,this.item.Name,this.item.Price,this.item.Quantity);
        }
    }
}

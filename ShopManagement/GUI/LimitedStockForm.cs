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
    public partial class LimitedStockForm : MetroForm
    {
        private ItemManager itemManager;
        private int quantity;
        private ListViewItem listItem;
        public LimitedStockForm()
        {
            InitializeComponent();
        }

        public LimitedStockForm(int quantity) : this()
        {
            itemManager = new ItemManager();
            this.quantity = quantity;
        }

        private void LimitedStockForm_Load(object sender, EventArgs e)
        {
            LoadListView(itemManager.StockWarning(quantity));
        }

        private void LoadListView(List<Item> items)
        {
            int slNo = 1;
            limitedStockListView.Items.Clear();
            foreach (Item item in items)
            {
                listItem = new ListViewItem(slNo.ToString());
                listItem.SubItems.Add(item.Id.ToString());
                listItem.SubItems.Add(item.Name);
                listItem.SubItems.Add(item.Quantity.ToString());
                listItem.SubItems.Add(item.Price.ToString());
                limitedStockListView.Items.Add(listItem);
                slNo++;
            }
        }
    }
}

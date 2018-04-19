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
using ShopManagement.DAL.DAO;
using ShopManagement.DAL.GateWay;

namespace ShopManagement.GUI
{
    public partial class TransactionForm : MetroForm
    {
        private List<Transaction> transactions;
        private TransactionDataAccess transactionDataAccess;
        private ListViewItem listViewItem;
        private double profit;
        public TransactionForm()
        {
            InitializeComponent();
            transactionDataAccess = new TransactionDataAccess();
        }

        private void viewMetroButton_Click(object sender, EventArgs e)
        {
            transactions = new List<Transaction>();
            try
            {
                transactions = transactionDataAccess.GetAllTransaction(fromDateTimePicker.Value, toDateTimePicker.Value);
                if (transactions == null)
                {
                    MessageBox.Show("No transaction", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    LoadListView(transactions);
                    if (profit < 0)
                    {
                        profitLabel.Text = String.Format("Expense is {0}k BDT more than income",-profit);
                    }
                    else
                    {
                        profitLabel.Text = String.Format("Income is {0}k BDT more than expense", profit);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error occured during loading database", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public void LoadListView(List<Transaction> transactionList)
        {
            profit = 0;
            int slNo = 1;
            transactionListView.Items.Clear();
            foreach (Transaction value in transactionList)
            {
                listViewItem = new ListViewItem(slNo.ToString());
                listViewItem.SubItems.Add(value.Date.ToString("dd-MMMM-yyyy"));
                listViewItem.SubItems.Add(value.Income.ToString());
                listViewItem.SubItems.Add(value.Expense.ToString());
                transactionListView.Items.Add(listViewItem);
                profit += value.Income;
                profit -= value.Expense;
                slNo++;
            }
            profit /= 1000;
        }
    }
}

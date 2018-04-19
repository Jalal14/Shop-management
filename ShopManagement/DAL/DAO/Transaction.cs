using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.DAL.DAO
{
    public class Transaction
    {
        private DateTime date;
        private double expense;
        private double income;

        public Transaction(DateTime date, double expense, double income)
        {
            this.Date = date;
            this.Expense = expense;
            this.Income = income;
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public double Expense
        {
            get { return expense; }
            set { expense = value; }
        }

        public double Income
        {
            get { return income; }
            set { income = value; }
        }
    }
}

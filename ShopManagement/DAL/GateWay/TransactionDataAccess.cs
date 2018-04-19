using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopManagement.DAL.DAO;

namespace ShopManagement.DAL.GateWay
{
    class TransactionDataAccess : DataAccess
    {
        public bool HasTransaction(DateTime date)
        {
            string query = string.Format("select id from transaction_table where date='{0}'", date.ToString("MM-dd-yyyy"));
            return base.QueryOperation(query);
        }

        public int AddExpense(DateTime date, double expense, double income)
        {
            string query = string.Format("insert into transaction_table (date,expense,income) values('{0}',{1},{2})",
                date.ToString("MM-dd-yyyy"), (float)expense,income);
            return base.NonQueryOperation(query);
        }

        public int AddIncome(DateTime date, double expense, double income)
        {
            string query = string.Format("insert into transaction_table (date,expense,income) values('{0}',{1},{2})",
                date.ToString("MM-dd-yyyy"), (float)expense, (float)income);
            return base.NonQueryOperation(query);
        }

        public int UpdateExpense(DateTime date, double value)
        {
            string query = String.Format("update transaction_table set expense=expense+{0} where date='{1}'", (float)value, date.ToString("MM-dd-yyyy"));
            return base.NonQueryOperation(query);
        }

        public int UpdateIncome(DateTime date, double value)
        {
            string query = String.Format("update transaction_table set income=income+{0} where date='{1}'", (float)value, date.ToString("MM-dd-yyyy"));
            return base.NonQueryOperation(query);
        }

        public List<Transaction> GetAllTransaction(DateTime from, DateTime to)
        {
            List<Transaction> transactions = new List<Transaction>();
            string query = string.Format("select * from transaction_table where date>= '{0}' and date<='{1}'",
                from.ToString("MM-dd-yyyy"), to.ToString("MM-dd-yyyy"));
            command = new SqlCommand(query,connection);
            command.Connection.Open();
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Transaction transaction = new Transaction(reader.GetDateTime(1),
                        reader.GetDouble(2),
                        reader.GetDouble(3));
                    transactions.Add(transaction);
                }
                command.Connection.Close();
                return transactions;
            }
            else
            {
                command.Connection.Close();
                return null;
            }
        }
    }
}

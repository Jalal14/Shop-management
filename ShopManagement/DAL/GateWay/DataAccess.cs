using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ShopManagement.DAL.GateWay
{
    public class DataAccess
    {
        protected SqlConnection connection;
        protected SqlCommand command;
        protected SqlDataReader reader;

        public DataAccess()
        {
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jalal\Desktop\ShopManagementApplication\ShopManagement\Shop.mdf;Integrated Security=True;Connect Timeout=30");
        }
        protected bool QueryOperation(string query)
        {
            command = new SqlCommand(query, connection);
            command.Connection.Open();
            reader = command.ExecuteReader();
            bool data = reader.HasRows;
            command.Connection.Close();
            return data;
        }

        protected int NonQueryOperation(string query)
        {
            command = new SqlCommand(query, connection);
            command.Connection.Open();
            int n = command.ExecuteNonQuery();
            command.Connection.Close();
            return n;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopManagement.DAL.DAO;

namespace ShopManagement.DAL.GateWay
{
    public class ItemDataAccess : DataAccess
    {
        private SqlDataReader reader;

        public bool HasThisId(int id)
        {
            string query = string.Format("select itemId from stock where itemId={0}", id);
            return base.QueryOperation(query);
        }

        public bool HasThisName(string name)
        {
            string query = string.Format("select name from stock where name='{0}'", name);
            return base.QueryOperation(query);
        }

        public bool HasWarning(int quantity)
        {
            string query = String.Format("select * from stock where quantity <= {0}",quantity);
            return base.QueryOperation(query);
        }

        public int AddItem(Item item)
        {
            string query = string.Format("insert into stock (itemId,name,quantity,price) values" +
                                         "({0},'{1}',{2},{3})", item.Id, item.Name, item.Quantity, (float) item.Price);
            return base.NonQueryOperation(query);
        }

        public int UpdateItemByName(Item item)
        {
            string query = string.Format("update stock set itemId={0},price={1} where name='{3}'",
                item.Id, (float) item.Price, item.Name);
            return base.NonQueryOperation(query);
        }

        public int SellProduct(int id,int quantity)
        {
            string query = String.Format("update stock set quantity=quantity-{0} where itemId={1}",quantity,id);
            return base.NonQueryOperation(query);
        }

        public int UpdateItemById(Item item)
        {
            string query = string.Format("update stock set name='{0}',price={1} where itemId={3}",
                item.Name, (float)item.Price, item.Id);
            return base.NonQueryOperation(query);
        }

        public int UpdateQuantity(int id, int quantity)
        {
            string query = String.Format("update stock set quantity=quantity+{0} where itemId={1}",quantity,id);
            return base.NonQueryOperation(query);
        }

        public double GetUnitPrice(int id)
        {
            double price = 0;
            string query = String.Format("select * from stock where itemId={0}",id);
            command = new SqlCommand(query,connection);
            command.Connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                price = reader.GetDouble(4);
            }
            command.Connection.Close();
            return price;
        }

        public int DeleteItem(int id,string name)
        {
            string query = string.Format("delete from stock where itemId={0} and name='{1}'", id, name);
            return base.NonQueryOperation(query);
        }
        public Item SearchItemById(int id)
        {
            string query = String.Format("select * from stock where itemId={0}",id);
            return SearchItem(query);
        }

        public Item SearchItemByName(string name)
        {
            string query = string.Format("select * from stock where name='{0}'", name);
            return SearchItem(query);
        }

        public Item SearchItem(string query)
        {
            Item item;
            command = new SqlCommand(query,connection);
            command.Connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(1);
                String name = reader.GetString(2);
                int quantity = reader.GetInt32(3);
                double price = reader.GetDouble(4);
                item=new Item(id,name,price,quantity);
                command.Connection.Close();
                return item;
            }
            command.Connection.Close();
            return null;
        }

        public List<Item> StockWarning(int quantity)
        {
            List<Item> items = new List<Item>();
            string query = String.Format("select * from stock where quantity <= {0}", quantity);
            command = new SqlCommand(query, connection);
            command.Connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Item item = new Item(reader.GetInt32(1),
                    reader.GetString(2),
                    reader.GetDouble(4),
                    reader.GetInt32(3));
                items.Add(item);
            }
            command.Connection.Close();
            return items;
        }
        public List<Item> GetAllItems()
        {
            string query = "select * from stock";
            return this.GetAll(query);
        }
        private List<Item> GetAll(string query)
        {
            if (!base.QueryOperation("select * from stock"))
            {
                return null;
            }
            else
            {
                List<Item> items = new List<Item>();
                command = new SqlCommand(query, connection);
                command.Connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(1);
                    string name = reader.GetString(2);
                    int quantity = reader.GetInt32(3);
                    double price = reader.GetDouble(4);
                    Item item = new Item(id,name,price,quantity);
                    items.Add(item);
                }
                command.Connection.Close();
                return items;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopManagement.DAL.DAO;
using ShopManagement.DAL.GateWay;

namespace ShopManagement.BLL
{
    public class ItemManager
    {
        private ItemDataAccess itemDataAccess;
        private TransactionDataAccess transactionDataAccess;
        public ItemManager()
        {
            itemDataAccess = new ItemDataAccess();
            transactionDataAccess = new TransactionDataAccess();
        }

        public bool HasWarning(int quantity)
        {
            return itemDataAccess.HasWarning(quantity);
        }
        public int AddItem(Item item)
        {
            if (itemDataAccess.HasThisId(item.Id))
            {
                return -1;
            }
            else if (itemDataAccess.HasThisName(item.Name))
            {
                return -2;
            }
            else
            {
                return itemDataAccess.AddItem(item);
            }
        }

        public int AddItem(Item item, double totalPrice)
        {
            int result = AddItem(item);
            if (result > 0)
            {
                if (transactionDataAccess.HasTransaction(DateTime.Today))
                {
                    return transactionDataAccess.UpdateExpense(DateTime.Today, totalPrice);
                }
                else
                {
                    return transactionDataAccess.AddExpense(DateTime.Today, totalPrice, 0);
                }
            }
            return result;
        }

        public int ForceAddItem(Item item)
        {
            return itemDataAccess.AddItem(item);
        }

        public int UpdateItemById(Item item)
        {
            if (!itemDataAccess.HasThisId(item.Id))
            {
                return -1;
            }
            else
            {
                return itemDataAccess.UpdateItemById(item);
            }
        }

        public int UpdateItemByName(Item item)
        {
            if (!itemDataAccess.HasThisName(item.Name))
            {
                return -1;
            }
            else
            {
                return itemDataAccess.UpdateItemByName(item);
            }
        }

        public int UpdateQUantity(int id, string name, int quantity)
        {
            if (!itemDataAccess.HasThisId(id) || !itemDataAccess.HasThisName(name))
            {
                return -1;
            }
            else
            {
                if (itemDataAccess.UpdateQuantity(id, quantity) <= 0)
                {
                    return -2;
                }
                else
                {
                    DateTime date = DateTime.Today;
                    double price = itemDataAccess.GetUnitPrice(id);
                    if (transactionDataAccess.HasTransaction(date))
                    {
                        return transactionDataAccess.UpdateExpense(date, quantity*price);
                    }
                    else
                    {
                        return transactionDataAccess.AddExpense(DateTime.Today, quantity * price, 0);
                    }
                }
            }
        }

        public int DeleteItem(int id, string name)
        {
            if (!itemDataAccess.HasThisId(id) || !itemDataAccess.HasThisName(name))
            {
                return -1;
            }
            else
            {
                return itemDataAccess.DeleteItem(id, name);
            }
        }

        public int SellItem(List<Item> items)
        {
            DateTime date = DateTime.Today;
            int i = 0;
            double income = 0;
            int success = 0;
            foreach (Item item in items)
            {
                success += itemDataAccess.SellProduct(item.Id, item.Quantity);
                i++;
                if (i==success)
                {
                    income += item.Quantity * item.Price;
                }
            }
            if (transactionDataAccess.HasTransaction(date))
            {
                int h = transactionDataAccess.UpdateIncome(date, income);
            }
            else
            {
                int n = transactionDataAccess.AddIncome(date, 0, income);
            }
            return success;
        }

        public Item SearchItemById(int id)
        {
            return itemDataAccess.SearchItemById(id);
        }
        public Item SearchItemByName(string name)
        {
            return itemDataAccess.SearchItemByName(name);
        }

        public List<Item> StockWarning(int quantity)
        {
            return itemDataAccess.StockWarning(quantity);
        }
        public List<Item> GetAllItems()
        {
            return itemDataAccess.GetAllItems();
        }
    }
}

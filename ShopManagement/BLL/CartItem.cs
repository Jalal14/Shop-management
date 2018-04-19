using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopManagement.DAL.DAO;

namespace ShopManagement.BLL
{
    public class CartItem : Item
    {
        private int ordered;

        public CartItem(int id, string name, double price, int quantity, int ordered) : base(id,name,price,quantity)
        {
            this.ordered = ordered;
        }

        public int Ordered
        {
            get { return ordered; }
            set { ordered = value; }
        }
    }
}

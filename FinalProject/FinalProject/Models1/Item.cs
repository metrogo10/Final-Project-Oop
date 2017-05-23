using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FinalProject
{
    public class Item
    {
        protected int Price;
        public int getPrice() { return Price; }
        public void setprice(int price) { this.Price = price; }
    }
}
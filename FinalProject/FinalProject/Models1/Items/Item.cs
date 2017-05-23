using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.Interfaces;
namespace FinalProject
{
    public class Item
    {
        protected int Price;
        protected double Wheight;
        public double getWheight() { return Wheight; }
        public void setWheight(double wheight) { this.Wheight = wheight; }
        public int getPrice() { return Price; }
        public void setprice(int price) { this.Price = price; }
    }
}
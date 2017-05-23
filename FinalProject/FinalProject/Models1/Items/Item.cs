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
        protected String Name;
        protected String Description;
        protected int Price;
        protected double Wheight;
        public double getWheight() { return Wheight; }
        public void setWheight(double wheight) { this.Wheight = wheight; }
        public int getPrice() { return Price; }
        public void setprice(int price) { this.Price = price; }
        public String getName(){return Name;}
        public void setName(String name){Name = name;}
        public String getDescription(){return Description; }
        public void setDescription(String description){Description = description;}
    }
}
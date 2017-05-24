using FinalProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FinalProject.Models1.Items
{
    public class UsefulItem : Item, IUsable
    {
        decimal stat = new decimal();
        public UsefulItem(string name, string description, int price, double wheight):base(name, description, price, wheight){ }
        public decimal Use(Character c)
        {
            c.DropItem(this);
            return this.stat;
        }
    }
}
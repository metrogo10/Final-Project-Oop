using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.Interfaces;
<<<<<<< HEAD
=======

>>>>>>> origin/master
namespace FinalProject.Models1.Items
{
    public class DefensiveItem : Item, IEquipable
    {
        public DefensiveItem(string name, string description, int price, double wheight) : base(name, description, price, wheight) { }
        public void Equip(Character c)
        {
            c.AddEquipment(this);
        }
        public void Remove(Character c)
        {
            c.UnEquip(this);
        }
    }
}
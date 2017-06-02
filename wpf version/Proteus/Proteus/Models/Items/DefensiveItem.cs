using Proteus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Proteus.Models.Items
{
	[Serializable]
    public class DefensiveItem : Item, IEquipable
    {
        public DefensiveItem(string name, string description, int price, double wheight) : base(name, description) { }
        public void Equip(Character c){ c.AddEquipment(this);}
        public void Remove(Character c)
        {
            c.UnEquip(this);
        }
    }
}
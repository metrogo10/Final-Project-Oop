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
        public UsefulItem(string name, string description) : base(name, description) { }
        public void Use(Character c)
        {
			foreach (ItemEffect e in Effects)
			{
				if (e.OnEquip)
				{
					e.Affect(c);
				}
			}
        }
    }
}
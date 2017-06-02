using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.Interfaces;
namespace FinalProject.Models1.Items
{
	public class DefensiveItem : Item, IEquipable
	{
		public DefensiveItem(string name, string description, int price, double wheight) : base(name, description) { }
		public void Equip(Character c)
		{
			foreach (ItemEffect effect in this.Effects)
			{
				if (effect.OnEquip)
				{
					effect.Affect(c);
				}
			}
		}
		public void Remove(Character c)
		{
			foreach (ItemEffect effect in Effects)
			{
				if (effect.OnEquip)
				{
					effect.Disaffect(c);
				}
			}
		}
	}
}
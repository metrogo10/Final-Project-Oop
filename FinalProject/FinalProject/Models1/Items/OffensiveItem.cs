using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.Interfaces;
namespace FinalProject.Models1.Items
{
	public class OffensiveItem : Item, IEquipable, IAttackable
	{
		private int numOfSides;

		public int Sides
		{
			get { return numOfSides; }
			set { numOfSides = value; }
		}

		private int numeOfDice;

		public int Dice
		{
			get { return numeOfDice; }
			set { numeOfDice = value; }
		}

		public OffensiveItem(string name, string description) : base(name, description)
		{
			List<NumDependency> nl = new List<NumDependency>();
			NumAttribute n = new NumAttribute("Attack", "1", 1, nl);
		}
		public decimal Attack()
		{
			Random r = new Random();
			Decimal d = (decimal)(Dice * r.Next(1, Sides + 1));
			return d;
		}
		public void Equip(Character c)
		{
			foreach (ItemEffect effect in this.Effects)
			{
				if (effect.OnEquip)
					effect.Affect(c);
			}
		}
		public void Remove(Character c)
		{
			foreach (ItemEffect effect in Effects)
			{
				if (effect.OnEquip)
					effect.Disaffect(c);
			}
		}
		public int getDieSides() { return Sides; }
		public void setDieSides(int dieSides) { this.Sides = dieSides; }
		public int getNumofDice() { return Dice; }
		public void setNumofDice(int numofDice) { this.Dice = numofDice; }
	}
}
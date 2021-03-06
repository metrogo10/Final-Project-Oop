﻿using FinalProject.Interfaces;
using FinalProject.Models1.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FinalProject
{
	[Serializable]
    public class Character
    {
        protected Race R;
        protected Archetype C;
        protected String name;
		public String Name
		{
			get { return name; }
			set { name = value; }
		}
		public Race Race
		{
			get { return R; }
			set { R = value; }
		}
		public Archetype Class
		{
			get { return C; }
			set { C = value; }
		}
		public Dictionary<string, Attribute> attributes = new Dictionary<string, Attribute>();
		protected List<Item> inventory = new List<Item>();
        protected List<IEquipable> heldItems = new List<IEquipable>();
		public Dictionary<string, Attribute> Attributes
		{
			get { return attributes; }
			set { attributes = value; }
		}
		public List<Item> Inventory
		{
			get { return inventory; }
			set { inventory = value; }
		}
		public List<IEquipable> HeldItems
		{
			get { return heldItems; }
			set { heldItems = value; }
		}
        public Race GetRace() { return R; }
        public Archetype GetClass() { return C; }
        public void SetRace(Race R) { this.R = R; }
        public void SetClass(Archetype C) { this.C = C; }
        public String getName() { return Name;}
        public void setName(String name){ Name = name; }
        public void AddStat(Attribute CD) { Attributes.Add(CD.Name, CD); }
        public void AddItem(Item IT) { Inventory.Add(IT); }
        public List<Item> GetItems() { return Inventory; }
        public void DropItem(Item IT) { Inventory.Remove(IT); }
        public void AddEquipment(IEquipable E)
		{ 
			if (Inventory.Contains((Item)E))
			{
				HeldItems.Add(E);
				Inventory.Remove((Item)E);
				E.Equip(this);
			}
		}
        public List<IEquipable> GetEquipment() { return HeldItems; }
        public void UnEquip(IEquipable E) { HeldItems.Remove(E); Inventory.Add((Item)E); }
		public override string ToString()
		{
			return $"{Name}, {R}, {C}\n";
		}
	}
}
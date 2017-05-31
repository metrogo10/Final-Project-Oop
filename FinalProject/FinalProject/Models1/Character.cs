using FinalProject.Interfaces;
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
        protected String Name;
        public Dictionary<string, CharacterAttribute> Attributes { get; set; }
        protected List<Item> Inventory;
        protected List<IEquipable> HeldItems;
        public Race GetRace() { return R; }
        public Archetype GetClass() { return C; }
        public void SetRace(Race R) { this.R = R; }
        public void SetClass(Archetype C) { this.C = C; }
        public String getName()
        {
            return Name;
        }
        public void setName(String name)
        {
            Name = name;
        }
        public void AddStat(CharacterAttribute CD) { Attributes.Add(CD.Name, CD); }
        public void AddItem(Item IT) { Inventory.Add(IT); }
        public List<Item> GetItems() { return Inventory; }
        public void DropItem(Item IT) { Inventory.Remove(IT); }
        public void AddEquipment(IEquipable E) { if (Inventory.Contains((Item)E) ){ Inventory.Remove((Item)E); } HeldItems.Add(E); }
        public List<IEquipable> GetEquipment() { return HeldItems; }
        public void UnEquip(IEquipable E) { HeldItems.Remove(E); Inventory.Add((Item)E); }

		public override string ToString()
		{
			return $"{Name}, {R}, {C}\n";
		}
	}
}
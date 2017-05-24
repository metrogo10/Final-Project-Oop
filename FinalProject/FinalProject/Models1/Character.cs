using FinalProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FinalProject
{
    public class Character
    {
        protected Race R;
        protected Archetype C;
        protected String Name;
        protected Dictionary<string, CharacterAttribute> Stats;
        protected List<Item> Inventory;
        protected List<IEquipable> HeldItems;
        public Race GetRace() { return R; }
        public Archetype GetClass() { return C; }
        public void SetRace(Race R) { this.R = R; }
        public void SetClass(Archetype C) { this.C = C; }
        public CharacterAttribute GetStat(string s)
        {
            CharacterAttribute CD = null;
            if (!string.IsNullOrEmpty(s)) { if (Stats.Keys.Contains(s)) { Stats.TryGetValue(s, out CD); } }
            return CD;
        }
        public String getName()
        {
            return Name;
        }
        public void setName(String name)
        {
            Name = name;
        }
        public Dictionary<string, CharacterAttribute> GetAllStats() { return Stats;  }
        public void AddStat(CharacterAttribute CD) { Stats.Add(CD.GetName(),CD); }
        public void AddItem(Item IT) { Inventory.Add(IT); }
        public List<Item> GetItems() { return Inventory; }
        public void DropItem(Item IT) { Inventory.Remove(IT); }
        public void AddEquipment(IEquipable E) { if (Inventory.Contains((Item)E) ){ Inventory.Remove((Item)E); } HeldItems.Add(E); }
        public List<IEquipable> GetEquipment() { return HeldItems; }
        public void UnEquip(IEquipable E) { HeldItems.Remove(E); Inventory.Add((Item)E); }
    }
}
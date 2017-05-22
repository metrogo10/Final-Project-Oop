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
        public Race GetRace() { return R; }
        public Archetype GetClass() { return C; }
        public void SetRace(Race R) { this.R = R; }
        public void SetClass(Archetype C) { this.C = C; }
        public CharacterAttribute GetStat(int x, string s)
        {
            CharacterAttribute CD = null;
            if (!string.IsNullOrEmpty(s)) { if (Stats.Keys.Contains(s)) { Stats.TryGetValue(s, out CD); } }
            else if (x > -1) { if (Stats.Count>=x) { CD = Stats.Values.ElementAt(x); } }
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
    }
}
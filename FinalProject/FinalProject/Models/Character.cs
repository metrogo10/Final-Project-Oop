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
        protected Class C;
        protected Dictionary<string, CharacterData> Stats;
        protected List<Item> Inventory;
        public Race GetRace() { return R; }
        public Class GetClass() { return C; }
        public void SetRace(Race R) { this.R = R; }
        public void SetClass(Class C) { this.C = C; }
        public CharacterData GetStat(int x, string s)
        {
            CharacterData CD = null;
            if (!string.IsNullOrEmpty(s)) { if (Stats.Keys.Contains(s)) { Stats.TryGetValue(s, out CD); } }
            else if (x > -1) { if (Stats.Count>=x) { CD = Stats.Values.ElementAt(x); } }
            return CD;
        }
        public Dictionary<string, CharacterData> GetAllStats() { return Stats;  }
        public void AddStat(CharacterData CD) { Stats.Add(CD.GetName(),CD); }
        public void AddItem(Item IT) { Inventory.Add(IT); }
        public List<Item> GetItems() { return Inventory; }
    }
}
using Proteus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Proteus.Models.Items
{
	[Serializable]
    public class UsefulItem : Item, IUsable
    {
        public UsefulItem(string name, string description) : base(name, description) { }
        public ItemEffect[] Use(Character c)
        {
            ItemEffect[] bob = new ItemEffect[this.effects.Count];
            for(int i = 0; i < bob.Length; i++) { bob[i] = this.effects.ElementAt(i); }
            return bob;
        }
    }
}
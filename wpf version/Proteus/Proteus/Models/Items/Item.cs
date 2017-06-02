using Proteus.Attributes;
using Proteus.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Proteus
{
	[Serializable]
    public class Item
    {
        protected String Name;
        protected String Description;
        public List<ItemEffect> effects { get; set; }
        public Item(string name, string description) {this.Name = name; this.Description = description;}
        public String getName(){return Name;}
        public void setName(String name){Name = name;}
        public String getDescription(){return Description; }
        public void setDescription(String description){Description = description;}
        public void AddEffect(ItemEffect IE) {effects.Add(IE); }
    }
}
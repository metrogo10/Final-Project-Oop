using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.Interfaces;
namespace FinalProject
{
    public class Item
    {
        protected String Name;
        protected String Description;
        public Dictionary<string, CharacterAttribute> Attributes { get; set; }
        public void AddStat(CharacterAttribute CD) { Attributes.Add(CD.Name, CD); }
        public Item(string name, string description, int price, double wheight)
        {
            this.Name = name; this.Description = description;
        }
        public String getName(){return Name;}
        public void setName(String name){Name = name;}
        public String getDescription(){return Description; }
        public void setDescription(String description){Description = description;}
    }
}
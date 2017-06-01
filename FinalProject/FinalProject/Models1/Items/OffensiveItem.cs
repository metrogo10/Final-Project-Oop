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
        protected int dieSides;
        protected int numofDice;
        public OffensiveItem(string name, string description) : base(name, description)
        {
            List<NumDependency> nl = new List<NumDependency>();
            NumAttribute n = new NumAttribute("Attack", "1", 1, nl);
        }
        public decimal Attack()
        {
            Random r = new Random();
            Decimal d = (decimal)(numofDice * r.Next(1, dieSides + 1));
            return d;
        }
        public void Equip(Character c) {c.AddEquipment(this); }
        public void Remove(Character c){c.UnEquip(this);}
        public int getDieSides(){return dieSides; }
        public void setDieSides(int dieSides){this.dieSides = dieSides;}
        public int getNumofDice(){ return numofDice;}
        public void setNumofDice(int numofDice){this.numofDice = numofDice;}
    }
}
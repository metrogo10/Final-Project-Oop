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
        protected Double multiplier;
        protected int dieSides;
        protected int numofDice;
        protected double modifier;
        public OffensiveItem(string name, string description, int price, double wheight) : base(name, description, price, wheight) { }
        public decimal Attack()
        {
            Random r = new Random();
            Decimal d = (decimal)(multiplier * (numofDice * r.Next(1, dieSides + 1)) + modifier);
            return d;
        }
        public void Equip(Character c)
        {
            c.AddEquipment(this);
        }
        public void Remove(Character c)
        {
            c.UnEquip(this);
        }
        public Double getMultiplier()
        {
            return multiplier;
        }
        public void setMultiplier(Double multiplier)
        {
            this.multiplier = multiplier;
        }
        public int getDieSides()
        {
            return dieSides;
        }
        public void setDieSides(int dieSides)
        {
            this.dieSides = dieSides;
        }
        public int getNumofDice()
        {
            return numofDice;
        }
        public void setNumofDice(int numofDice)
        {
            this.numofDice = numofDice;
        }
        public double getModifier()
        {
            return modifier;
        }
        public void setModifier(double modifier)
        {
            this.modifier = modifier;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FinalProject.Models1.Items
{
	public enum EffectType
	{
		ADD,
		SUBTRACT,
		MULTIPLY,
		DIVIDE
	}

	/// <summary>
	/// ItemEffect is a class which all items will contain, that tells the character holding or equipping the item what that item does to their attributes.
	/// </summary>
	public class ItemEffect
	{
		private bool onEquip;

		/// <summary>
		/// Whether or not the item's effect is applied on equip.
		/// </summary>
		public bool OnEquip
		{
			get { return onEquip; }
			set { onEquip = value; }
		}

		private bool onHold;

		/// <summary>
		/// Whether or not the item's effect is applied from the character's inventory.
		/// </summary>
		public bool OnHold
		{
			get { return onHold; }
			set { onHold = value; }
		}


		private string attributeRef;

		/// <summary>
		/// The attribute this effect is affecting.
		/// </summary>
		public string Attribute
		{
			get { return attributeRef; }
			set { attributeRef = value; }
		}


		private EffectType effect;

		/// <summary>
		/// The type of operation this effect is implimenting.
		/// </summary>
		public EffectType Effect
		{
			get { return effect; }
			set { effect = value; }
		}


		private decimal value;

		/// <summary>
		/// The amount this effect affects an attribute by.
		/// </summary>
		public decimal Value
		{
			get { return value; }
			set { this.value = value; }
		}

		/// <summary>
		/// Constructor for an item effect.
		/// </summary>
		/// <param name="atribRef">The attribute this effect will modify.</param>
		/// <param name="effect">The way this effect will modify the referenced attribute.</param>
		/// <param name="value">The amount this effect will modify the attribute by.</param>
		public ItemEffect(string atribRef, EffectType effect, decimal value)
		{
			Attribute = atribRef;
			Effect = effect;
			Value = value;
		}

		/// <summary>
		/// Takes in a character and modifies one of the attributes based on the effect's parameters.
		/// </summary>
		/// <param name="character">The character this effect is applying its effects to.</param>
		public void Affect(Character character)
		{
			switch (Effect)
			{
				case EffectType.ADD:
					((NumAttribute)character.Attributes[attributeRef]).Value += this.Value;
					break;
				case EffectType.SUBTRACT:
					((NumAttribute)character.Attributes[attributeRef]).Value -= this.Value;
					break;
				case EffectType.MULTIPLY:
					((NumAttribute)character.Attributes[attributeRef]).Value *= this.Value;
					break;
				case EffectType.DIVIDE:
					((NumAttribute)character.Attributes[attributeRef]).Value /= this.Value;
					break;
			}
		}

		/// <summary>
		/// Removes the modifications applied by this effect.
		/// </summary>
		/// <param name="character">The character this effect is applying its effects to.</param>
		public void Disaffect(Character character)
		{
			switch(Effect)
			{
				case EffectType.ADD:
					((NumAttribute)character.Attributes[attributeRef]).Value -= this.Value;
					break;
				case EffectType.SUBTRACT:
					((NumAttribute)character.Attributes[attributeRef]).Value += this.Value;
					break;
				case EffectType.DIVIDE:
					((NumAttribute)character.Attributes[attributeRef]).Value /= this.Value;
					break;
				case EffectType.MULTIPLY:
					((NumAttribute)character.Attributes[attributeRef]).Value *= this.Value;
					break;
			}
		}
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.Models1;
namespace FinalProject.Engines
{
	/// <summary>
	/// The Courier is a static class which serves as an engine to fetch and deliver information for instances of attribute or dependancy. 
	/// This allows a dependancy to access the attribute it is stored in, and allows attributes to access other attributes in the same character.
	/// </summary>
	/// <remarks>
	/// It is named so because it is used to carry information back and forth between dependancies, attributes, and characters,
	/// allowing bottom level classes to speak with the top level classes they are stored within.
	/// </remarks>
	public static class Courier
	{
		/// <summary>
		/// This method allows a dependancy to find the value of another attribute from the character it belongs to.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="attributeReference"></param>
		public static decimal GetValue(string attributeReference, int sourceID)
		{
			bool source = false;
			decimal retVal = 0;
			foreach (KeyValuePair<string, Character> character in MainEngine.Characters)
			{
				foreach(KeyValuePair<string, Attribute> attribute in character.Value.Attributes)
				{
					if (attribute.Value.GetType()==typeof(NumAttribute))
					{
						foreach(NumDependency d in ((NumAttribute)attribute.Value).Dependancies)
						{
							if (d.ID == sourceID)
							{
								source = true;
								break;
							}
						}
						if (source)
						{
							break;
						}
					}
				}
				if (source)
				{
					retVal = ((NumAttribute)character.Value.Attributes[attributeReference]).GetValue();
				}
			}

			return retVal;
		}
		/// <summary>
		/// Analyzes an attribute and returns whether or not it is valid.
		/// </summary>
		/// <param name="character">The character to analyze.</param>
		/// <param name="attribute">The characters attribute to check.</param>
		/// <param name="dependency">The dependency to check with.</param>
		/// <returns>A string array containing useful error messages. If empty, no errors were found.</returns>
		public static string[] ValidateAttribute(Character character, NumAttribute attribute)
		{
			List<string> errors = new List<string>();
			attribute.setMax(FindHighestPossible(character, attribute));
			attribute.setMin(FindLowestPossible(character, attribute));
			if (attribute.getMax() < attribute.getMin())
			{
				errors.Add(attribute.Name + " has a higher minimum value than its maximum value, meaning it can never be correct.");
			}
			foreach(NumDependency d in attribute.Dependancies)
			{
				if ((d.type==Operand.QuotiantOf || d.type==Operand.ModuloOf))
				{
					if (d.v2IsRef)
					{
						if (Zeroable(character, (NumAttribute)character.Attributes[d.v2Ref]))
						{
							errors.Add(attribute.Name + " is derived by dividing by zero, or could potentially be derived by dividing by zero.\n" +
								"Ensure that no attributes depended upon by " + attribute.Name + " can potentially be zero.");
						}
					}
					else if (d.Value2 == 0)
					{
						errors.Add(attribute.Name + " is derived by dividing by zero, or could potentially be derived by dividing by zero.\n" +
								"Ensure that no attributes depended upon by " + attribute.Name + " can potentially be zero.");
					}
				}
			}
			return errors.ToArray();
		}
		/// <summary>
		/// Takes an instance of character and a specific attribute within that character, and returns the highest value that attribute can potentially have.
		/// </summary>
		/// <param name="character">The instance of character your attribute is stored within.</param>
		/// <param name="attribute">The attribute you are validating</param>
		/// <returns>The highest number the attribute is allowed to be based on its dependencies</returns>
		private static decimal FindHighestPossible(Character character, NumAttribute attribute)
		{
		    decimal highestPossible = decimal.MaxValue;
			//This method is recursive. To save on memory, if it runs once it'll store the value it returns in the attribute's max value.
			//If this method is called on an attribute it has already been called on, it will simply return the already stored max value.
			//In order to ensure we can validate attributes when a player updates them, we should set max and min values to null in any attribute that is edited.
			if (attribute.getMax()!=null)
			{
				highestPossible = (decimal) attribute.getMax();
			}
			else
			{
				foreach(NumDependency d in attribute.Dependancies)
				{
					// >Inb4 longest switch statement I've ever written.
					// >It's super ugly, but super functional.
					// >I feel fulfilled and disgusted simultaneously
					// >Mfw: http://i.imgur.com/c65CEFK.png
					switch (d.type)
					{
						case Operand.Equals:
							if (d.v1IsRef)
							{
								highestPossible = FindHighestPossible(character, (NumAttribute)character.Attributes[d.v1Ref]);
							}
							else
							{
								highestPossible = d.Value1;
							}
							attribute.setMax(highestPossible);
							break;
						case Operand.DifferenceOf:
							decimal x = d.v1IsRef ? FindHighestPossible(character, (NumAttribute)character.Attributes[d.v1Ref]) : d.Value1;
							decimal y = d.v2IsRef ? FindHighestPossible(character, (NumAttribute)character.Attributes[d.v2Ref]) : d.Value2;
							highestPossible = x - y;
							attribute.setMax(highestPossible);
							break;
						case Operand.LessThan:
						case Operand.LessOrEqualTo:
							if (d.v1IsRef)
							{
								NumAttribute n = (NumAttribute)character.Attributes[d.v1Ref];
								if (n.getMax() - (d.type == Operand.LessOrEqualTo ? 0 : 1) > highestPossible)
								{
									highestPossible = FindHighestPossible(character, (NumAttribute)character.Attributes[d.v1Ref]) - (d.type == Operand.LessOrEqualTo ? 0 : 1);
								}
							}
							else
							{
								if (d.Value1 > highestPossible)
									highestPossible = d.Value1 - (d.type == Operand.LessOrEqualTo ? 0 : 1);
							}
							break;
						case Operand.LogOf:
							break;
						case Operand.ModuloOf:
							x = d.v1IsRef ? FindHighestPossible(character, (NumAttribute)character.Attributes[d.v1Ref]) : d.Value1;
							y = d.v2IsRef ? FindHighestPossible(character, (NumAttribute)character.Attributes[d.v2Ref]) : d.Value2;
							highestPossible = x % y;
							attribute.setMax(highestPossible);
							break;
						case Operand.PowerOf:
							break;
						case Operand.ProductOf:
							x = d.v1IsRef ? FindHighestPossible(character, (NumAttribute)character.Attributes[d.v1Ref]) : d.Value1;
							y = d.v2IsRef ? FindHighestPossible(character, (NumAttribute)character.Attributes[d.v2Ref]) : d.Value2;
							highestPossible = x * y;
							attribute.setMax(highestPossible);
							break;
						case Operand.QuotiantOf:
							x = d.v1IsRef ? FindHighestPossible(character, (NumAttribute)character.Attributes[d.v1Ref]) : d.Value1;
							y = d.v2IsRef ? FindHighestPossible(character, (NumAttribute)character.Attributes[d.v2Ref]) : d.Value2;
							highestPossible = x / y;
							attribute.setMax(highestPossible);
							break;
						case Operand.SumOf:
							x = d.v1IsRef ? FindHighestPossible(character, (NumAttribute)character.Attributes[d.v1Ref]) : d.Value1;
							y = d.v2IsRef ? FindHighestPossible(character, (NumAttribute)character.Attributes[d.v2Ref]) : d.Value2;
							highestPossible = x + y;
							attribute.setMax(highestPossible);
							break;
					}
				}
			}
			attribute.setMax(highestPossible);
			return highestPossible;
		}
		/// <summary>
		/// Takes an instance of character and a specific attribute within that character, and returns the lowest value that attribute can potentially have.
		/// </summary>
		/// <param name="character">The instance of character your attribute is stored within.</param>
		/// <param name="attribute">The attribute you are validating</param>
		/// <returns>The lowest number the attribute is allowed to be based on its dependencies</returns>
		private static decimal FindLowestPossible(Character character, NumAttribute attribute)
		{
			decimal lowestPossible = -decimal.MaxValue;
			if (attribute.getMin() != null)
			{
				lowestPossible = (decimal)attribute.getMin();
			}
			else
			{
				foreach (NumDependency d in attribute.Dependancies)
				{
					switch (d.type)
					{
						case Operand.Equals:
							if (d.v1IsRef)
							{
								lowestPossible = FindLowestPossible(character, (NumAttribute)character.Attributes[d.v1Ref]);
							}
							else
							{
								lowestPossible = d.Value1;
							}
							attribute.setMin(lowestPossible);
							break;
						case Operand.DifferenceOf:
							decimal x = d.v1IsRef ? FindLowestPossible(character, (NumAttribute)character.Attributes[d.v1Ref]) : d.Value1;
							decimal y = d.v2IsRef ? FindLowestPossible(character, (NumAttribute)character.Attributes[d.v2Ref]) : d.Value2;
							lowestPossible = x - y;
							attribute.setMin(lowestPossible);
							break;
						case Operand.LessThan:
						case Operand.LessOrEqualTo:
							if (d.v1IsRef)
							{
								NumAttribute n = (NumAttribute)character.Attributes[d.v1Ref];
								if (n.getMin() - (d.type == Operand.LessOrEqualTo ? 0 : 1) > lowestPossible)
								{
									lowestPossible = FindLowestPossible(character, n) - (d.type == Operand.LessOrEqualTo ? 0 : 1);
								}
							}
							else
							{
								if (d.Value1 > lowestPossible)
									lowestPossible = d.Value1 - (d.type == Operand.LessOrEqualTo ? 0 : 1);
							}
							break;
						case Operand.LogOf:
							break;
						case Operand.ModuloOf:
							x = d.v1IsRef ? FindLowestPossible(character, (NumAttribute)character.Attributes[d.v1Ref]) : d.Value1;
							y = d.v2IsRef ? FindLowestPossible(character, (NumAttribute)character.Attributes[d.v2Ref]) : d.Value2;
							lowestPossible = x % y;
							attribute.setMin(lowestPossible);
							break;
						case Operand.PowerOf:
							break;
						case Operand.ProductOf:
							x = d.v1IsRef ? FindLowestPossible(character, (NumAttribute)character.Attributes[d.v1Ref]) : d.Value1;
							y = d.v2IsRef ? FindLowestPossible(character, (NumAttribute)character.Attributes[d.v2Ref]) : d.Value2;
							lowestPossible = x * y;
							attribute.setMin(lowestPossible);
							break;
						case Operand.QuotiantOf:
							x = d.v1IsRef ? FindLowestPossible(character, (NumAttribute)character.Attributes[d.v1Ref]) : d.Value1;
							y = d.v2IsRef ? FindLowestPossible(character, (NumAttribute)character.Attributes[d.v2Ref]) : d.Value2;
							lowestPossible = x / y;
							attribute.setMin(lowestPossible);
							break;
						case Operand.SumOf:
							x = d.v1IsRef ? FindLowestPossible(character, (NumAttribute)character.Attributes[d.v1Ref]) : d.Value1;
							y = d.v2IsRef ? FindLowestPossible(character, (NumAttribute)character.Attributes[d.v2Ref]) : d.Value2;
							lowestPossible = x + y;
							attribute.setMin(lowestPossible);
							break;
					}
				}
			}
			attribute.setMin(lowestPossible);
			return lowestPossible;
		}
		/// <summary>
		/// Checks an attribute to see if it is ever possible for it to be zero. Useful for knowing if it is always safe to divide by this attribute.
		/// </summary>
		/// <param name="character">The character the checked attribute is stored within.</param>
		/// <param name="attribute">The attribute you are checking.</param>
		/// <returns>Whether or not the attribute can ever, for any reason, at any time, be zero.</returns>
		private static bool Zeroable(Character character, NumAttribute attribute)
		{
			bool zeroable = true;
			if (attribute.Zeroable!=null)
			{
				zeroable = (bool) attribute.Zeroable;
			}
			else
			{
				if (FindHighestPossible(character, attribute) >=0 && FindLowestPossible(character, attribute) <= 0)
				{
					zeroable = true;
				}
			}
			attribute.Zeroable = zeroable;
			return zeroable;
		}
		/// <summary>
		/// This method is called upon an attribute to check all of its referenced attributes, and make sure no circular logic is present.
		/// </summary>
		/// <param name="character">The character the attribute you are checking is stored in.</param>
		/// <param name="attribute">The attribute you are checking</param>
		/// <param name="referenced">All attributes which have already been checked in the line of recursion.</param>
		/// <returns>A string[] containing all attributes the checked attribute relies on which resulted in circular logic.</returns>
		private static string[] CheckCircularReferences(Character character, NumAttribute attribute, List<NumAttribute> alreadyChecked = null)
		{
			List<string> referenceErrors = new List<string>();
			//Initialize the alreadyChecked list if this is the first instance of this method to be called per recursive line.
			if (alreadyChecked == null)
				alreadyChecked = new List<NumAttribute>();
			//Add the current attribute to the list of checked attributes. That list will be used to make sure an attribute doesn't reference itself, even indirectly.
			alreadyChecked.Add(attribute);
			foreach (NumDependency d in attribute.Dependancies)
			{
				if (d.v1IsRef)
				{
					if (alreadyChecked.Contains(character.Attributes[d.v1Ref]))
					{

					}
				}
				if (d.v2IsRef)
				{

				}
			}
			return referenceErrors.ToArray();
		}
	}
}

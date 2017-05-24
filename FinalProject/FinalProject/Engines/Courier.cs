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
		/// Analyzes a dependency and returns whether or not it is valid.
		/// </summary>
		/// <param name="character">The character to analyze.</param>
		/// <param name="attribute">The characters attribute to check.</param>
		/// <param name="dependency">The dependency to check with.</param>
		/// <returns>Whether the dependency is valid.</returns>
		public static bool ValidateDependacy(Character character, NumAttribute attribute, NumDependency dependancy)
		{
			bool isValid = true;

			switch (dependancy.Type)
			{
				case Operand.QuotiantOf:
					isValid = ValidateQuotiant(character, attribute, dependancy);
					break;
				case Operand.GreaterOrEqualTo:
					isValid = ValidateGreaterThanEqualTo(character, attribute, dependancy);
					break;
				case Operand.GreaterThan:
					isValid = ValidateGreaterThan(character, attribute, dependancy);
					break;
				case Operand.LessOrEqualTo:
					isValid = ValidateLessThanEqualTo(character, attribute, dependancy);
					break;
				case Operand.LessThan:
					isValid = ValidateLessThan(character, attribute, dependancy);
					break;
			}

			return isValid;
		}

		private static bool ValidateQuotiant(Character character, NumAttribute attribute, NumDependency dependancy)
		{
			bool isValid = true;

			if (dependancy.v2IsRef)
			{

			}
			else if (dependancy.Value2 == 0)
			{
				isValid = false;
			}

			return isValid;
		}

		private static bool ValidateGreaterThanEqualTo(Character character, NumAttribute attribute, NumDependency dependancy)
		{
			bool isValid = true;



			return isValid;
		}

		private static bool ValidateGreaterThan(Character character, NumAttribute attribute, NumDependency dependancy)
		{
			bool isValid = true;



			return isValid;
		}

		private static bool ValidateLessThanEqualTo(Character character, NumAttribute attribute, NumDependency dependancy)
		{
			bool isValid = true;



			return isValid;
		}

		private static bool ValidateLessThan(Character character, NumAttribute attribute, NumDependency dependancy)
		{
			bool isValid = true;

			if (dependancy.v1IsRef)
			{
				
			}
			else
			{

			}

			return isValid;
		}
		private static decimal FindHighestPossible(Character character, NumAttribute attribute, NumDependency dependancy)
		{
		    return 0;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.Models1;
namespace FinalProject.Engines
{
	/*
	 * The Courier is a static class which serves as an engine to fetch and deliver information for instances of attribute or dependancy. 
	 * This allows a dependancy to access the attribute it is stored in, and allows attributes to access other attributes in the same character.
	 * 
	 * It is named so because it is used to carry information back and forth between dependancies, attributes, and characters,
	 * allowing bottom level classes to speak with the top level classes they are stored within.
	 */
	public static class Courier
	{
		/*
		 * ValidateDependancies() is designed to ensure that there are no potential conflicts within an attribute's dependancies.
		 * This method is to be used during the declaration of an attribute, to ensure that errors will not appear in the future.
		 * Not to be used after declaration.
		 * 
		 * This method will run through all other dependancies on the same character as the one it is checking, and look for conflicts.
		 * If any are found, it will return false. Our GUI should run this method for each field the user enters, and if even one returns false,
		 * mark the ones that did, popup an error message, and disalow continuation. This method is primarily a switchboard, which delegates and rerouts the task to private methods found below.
		 */
		public static bool ValidateDependacy(Character character, NumAttribute attribute, NumDependancy dependancy)
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
		private static bool ValidateQuotiant(Character character, NumAttribute attribute, NumDependancy dependancy)
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
		private static bool ValidateGreaterThanEqualTo(Character character, NumAttribute attribute, NumDependancy dependancy)
		{
			bool isValid = true;



			return isValid;
		}
		private static bool ValidateGreaterThan(Character character, NumAttribute attribute, NumDependancy dependancy)
		{
			bool isValid = true;



			return isValid;
		}
		private static bool ValidateLessThanEqualTo(Character character, NumAttribute attribute, NumDependancy dependancy)
		{
			bool isValid = true;



			return isValid;
		}
		private static bool ValidateLessThan(Character character, NumAttribute attribute, NumDependancy dependancy)
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
		private static decimal FindHighestPossible(Character character, NumAttribute attribute, NumDependancy dependancy)
		{

		}
	}
}

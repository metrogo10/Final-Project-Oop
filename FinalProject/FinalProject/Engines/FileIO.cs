using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Engines
{
	/// <summary>
	/// FileIO is this program's save/load class, which impliments serialization to effeciently save and load characters.
	/// </summary>
	public static class FileIO
	{
		/// <summary>
		/// To be called by the MainEngine class to save its character template.
		/// </summary>
		public static void SaveRuleset()
		{
			IFormatter formatter = new BinaryFormatter();
			Stream stream = new FileStream("rulesets\\" + MainEngine.RulesetName + "\\"+MainEngine.RulesetName + ".tbltp", FileMode.Create, FileAccess.ReadWrite);
			formatter.Serialize(stream, MainEngine.Template);
			stream.Close();
		}

		/// <summary>
		/// To be called by MainEngine to load a ruleset.
		/// </summary>
		/// <param name="rulesetName">The name of the ruleset the user wishes to load</param>
		/// <returns>The save ruleset by the given name</returns>
		public static Character LoadRuleset(string rulesetName)
		{
			IFormatter formatter = new BinaryFormatter();
			Stream stream = new FileStream("rulesets\\" + rulesetName + "\\" + rulesetName + ".tbltp", FileMode.Create, FileAccess.ReadWrite);
			Character template = (Character) formatter.Deserialize(stream);
			return template;
		}

		/// <summary>
		/// Saves a given character to a file with a name matching the character's.
		/// </summary>
		/// <param name="character">The character you wish to save.</param>
		public static void SaveCharacter(Character character)
		{
			IFormatter formatter = new BinaryFormatter();
			Stream stream = new FileStream("rulesets\\" + MainEngine.RulesetName + "\\" + character.getName() + ".tbltp", FileMode.Create, FileAccess.ReadWrite);
			formatter.Serialize(stream, character);
			stream.Close();
		}

		/// <summary>
		/// Loads a character by the given name.
		/// </summary>
		/// <param name="characterName">The name of the character you wish to load.</param>
		/// <returns>The loaded character</returns>
		public static Character LoadCharacter(string characterName)
		{
			IFormatter formatter = new BinaryFormatter();
			Stream stream = new FileStream("rulesets\\" + MainEngine.RulesetName + "\\" + characterName + ".tbltp", FileMode.Create, FileAccess.ReadWrite);
			Character template = (Character)formatter.Deserialize(stream);
			return template;
		}
	}
}

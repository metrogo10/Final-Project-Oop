using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
namespace Proteus.Engines
{
	/// <summary>
	/// FileIO is this program's save/load class, which impliments serialization to effeciently save and load characters.
	/// </summary>
	public static class FileIO
	{
		/// <summary>
		/// To be called by the MainEngine class to save its character template.
		/// </summary>
		public static void SaveCharacter(string filePath, Character character)
		{
			IFormatter formatter = new BinaryFormatter();
			Stream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
			formatter.Serialize(stream, character);
			stream.Close();
		}

		/// <summary>
		/// To be called by MainEngine to load a ruleset.
		/// </summary>
		/// <param name="rulesetName">The name of the ruleset the user wishes to load</param>
		/// <returns>The save ruleset by the given name</returns>
		public static Character LoadCharacter(string filePath)
		{
			IFormatter formatter = new BinaryFormatter();
			Stream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
			Character template = (Character) formatter.Deserialize(stream);
			stream.Close();
			return template;
		}

		public static Item LoadItem(string filepath)
		{
			IFormatter formatter = new BinaryFormatter();
			Stream stream = new FileStream(filepath, FileMode.Open, FileAccess.Read);
			Item item = (Item)formatter.Deserialize(stream);
			stream.Close();
			return item;
		}
		
		public static void SaveItem(string filePath, Item item)
		{
			IFormatter formatter = new BinaryFormatter();
			Stream stream = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite);
			formatter.Serialize(stream, item);
			stream.Close();
		}
	}
}

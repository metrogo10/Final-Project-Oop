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
	public static class FileIO
	{

		public static void SaveRuleset()
		{
			IFormatter formatter = new BinaryFormatter();
			Stream stream = new FileStream("rulesets\\" + MainEngine.RulesetName + "\\"+MainEngine.RulesetName + ".tbltp", FileMode.Create, FileAccess.ReadWrite);
			formatter.Serialize(stream, MainEngine.Template);
			stream.Close();
		}

		public static Character LoadRuleset(string rulesetName)
		{
			IFormatter formatter = new BinaryFormatter();
			Stream stream = new FileStream("rulesets\\" + rulesetName + "\\" + rulesetName + ".tbltp", FileMode.Create, FileAccess.ReadWrite);
			Character template = (Character) formatter.Deserialize(stream);
			return template;
		}

		public static void SaveCharacter(Character character)
		{
			if (!Directory.Exists("rulesets\\" + MainEngine.RulesetName))
			{
				Directory.CreateDirectory("rulesets\\" + MainEngine.RulesetName);
			}
			if (!File.Exists("rulesets\\" + MainEngine.RulesetName + "\\" + character.getName() + ".tbltp"))
			{
				FileStream tempStream = File.Create("rulesets\\" + MainEngine.RulesetName + "\\" + character.getName() + ".tbltp");
			}
			IFormatter formatter = new BinaryFormatter();
			Stream stream = new FileStream("rulesets\\" + MainEngine.RulesetName + "\\" + character.getName() + ".tbltp", FileMode.Create, FileAccess.ReadWrite);
			formatter.Serialize(stream, character);
			stream.Close();
		}

		public static Character LoadCharacter(string characterName)
		{
			IFormatter formatter = new BinaryFormatter();
			Stream stream = new FileStream("rulesets\\" + MainEngine.RulesetName + "\\" + characterName + ".tbltp", FileMode.Open, FileAccess.ReadWrite);
			Character template = (Character)formatter.Deserialize(stream);
			return template;
		}
	}
}

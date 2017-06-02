using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Engines
{
	public static class MainEngine
	{
		//The ruleset is a character template.
		private static Character template;
		private static string rulesetName;

		//This is a list of all the characters presently loaded.
		private static Dictionary<string, Character> characters = new Dictionary<string, Character>();

		//A dictionary of item templates. The key is their item type, and must be unique.
		private static Dictionary<string, Item> itemTemplates = new Dictionary<string, Item>();

		//This is a dictionary of all the items presently loaded.
		private static Dictionary<string, Item> items;

		public static Dictionary<string, Item> Items
		{
			get { return items; }
			set { items = value; }
		}


		public static Dictionary<string, Character> Characters
		{
			get { return characters; }
			set { characters = value; }
		}

		public static string RulesetName
		{
			get { return rulesetName; }
			set { rulesetName = value; }
		}


		public static Character Template
		{
			get { return template; }
			set { template = value; }
		}

		public static Dictionary<string, Item> ItemTemplates { get => ItemTemplates; set => ItemTemplates = value; }
	}
}

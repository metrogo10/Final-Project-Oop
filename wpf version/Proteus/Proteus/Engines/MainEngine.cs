using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Proteus.Engines
{
	public static class MainEngine
	{
		private static Character template;
		private static string rulesetName;
		private static Character currentCharacter;
		private static Dictionary<string, Item> items;

		public static Dictionary<string, Item> Items
		{
			get { return items; }
			set { items = value; }
		}


		public static Character Character
		{
			get { return currentCharacter; }
			set { currentCharacter = value; }
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

	}
}

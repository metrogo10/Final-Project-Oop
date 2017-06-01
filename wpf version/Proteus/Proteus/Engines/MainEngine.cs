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
		private static Dictionary<string, Character> characters = new Dictionary<string, Character>();

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

	}
}

using Proteus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Proteus.Attributes
{
	public static class RandomGenerator
	{
		public static Character GenerateCharacter(Character template)
		{
			Character returnValue;
			List<Attribute> attributes = new List<Attribute>();

			foreach(KeyValuePair<string, CustomAttribute> atbPair in template.Attributes)
			{

			}
			throw new NotImplementedException();
		}
	}
}
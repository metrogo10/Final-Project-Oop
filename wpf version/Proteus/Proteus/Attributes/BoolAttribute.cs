using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proteus.Attributes
{
	class BoolAttribute : CustomAttribute
	{
		bool isTrue;
		public BoolAttribute(string name, string group, int priority) : base(name, group, priority)
		{

		}
	}
}

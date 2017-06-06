using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proteus.Attributes
{
	class TextAttribute : CustomAttribute
	{
		private string contents;

		public string Contents
		{
			get { return contents; }
			set { contents = value; }
		}

		public TextAttribute(string name, string group, int priority, string textContents) : base(name, group, priority)
		{
			Contents = textContents;
		}
	}
}

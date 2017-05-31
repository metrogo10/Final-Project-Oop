using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FinalProject
{
	[Serializable]
    public abstract class CharacterAttribute
	{
		public string Name { get; set; }
		public readonly int ID;
		private static int count;

		public static int Count
		{
			get { return count; }
			set
			{
				if (value < count)
					value = count;
				count = value;
			}
		}
		protected string Group;
        protected int group;
        protected int priority;
        public int getGroup()
        {
            return group;
        }
        public void setGroup(int group)
        {
            this.group = group;
        }
        public int getPriority()
        {
            return priority;
        }
        public void setPriority(int priority)
        {
            this.priority = priority;
        }
        public String GetGroup()
        {
            return Group;
        }
        public void setGroup(String group)
        {
            Group = group;
        }
		public CharacterAttribute(string name, string group, int priority)
		{
			Name = name;
			this.Group = group;
			this.priority = priority;
			ID = count++;
		}
		public abstract string[] Save();
	}
}
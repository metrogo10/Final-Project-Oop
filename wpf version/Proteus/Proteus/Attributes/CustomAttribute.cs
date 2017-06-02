using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Proteus.Attributes
{
	[Serializable]
    public abstract class CustomAttribute
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
		public string Group { get; set; }
        public int GroupNum { get; set; }
        public int Priority { get; set; }
        public int getGroup()
        {
            return GroupNum;
        }
        public void setGroup(int group)
        {
            this.GroupNum = group;
        }
        public int getPriority()
        {
            return Priority;
        }
        public void setPriority(int priority)
        {
            this.Priority = priority;
        }
        public String GetGroup()
        {
            return Group;
        }
        public void setGroup(String group)
        {
            Group = group;
        }
		public CustomAttribute(string name, string group, int priority)
		{
			Name = name;
			this.Group = group;
			this.Priority = priority;
			ID = count++;
		}
	}
}
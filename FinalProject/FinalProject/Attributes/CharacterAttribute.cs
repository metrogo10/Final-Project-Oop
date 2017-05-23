using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FinalProject
{
    public class CharacterAttribute
    {
        protected string Name;
        protected string Group;
        protected int group;
        protected int priority;
        public String GetName()
        {
            return Name;
        }
        public void setName(String name)
        {
            Name = name;
        }
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
    }
}
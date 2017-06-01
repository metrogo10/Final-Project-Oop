using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FinalProject
{
	[Serializable]
    public class Archetype
    {
        protected String Name;
        protected String Description;
        public String getName()
        {
            return Name;
        }
        public void setName(String name)
        {
            Name = name;
        }
        public String getDescription()
        {
            return Description;
        }
        public void setDescription(String description)
        {
            Description = description;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Proteus
{
    public class CharacterData<E>
    {
        private string Name;
		private E data;
        public String GetName() { return Name; }
    }
}
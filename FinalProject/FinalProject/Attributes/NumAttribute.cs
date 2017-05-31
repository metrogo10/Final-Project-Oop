using FinalProject.Models1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FinalProject
{
	[Serializable]
    public class NumAttribute : CharacterAttribute
    {
        private decimal Value;
        private decimal? max = null;
        private decimal? min = null;
		public NumAttribute(string name, string group, int priority, List<NumDependency> dependencies) : base(name, group, priority)
		{
			Dependancies = dependencies;
			Zeroable = null;
		}
		public bool? Zeroable { get; set; }
        public List<NumDependency> Dependancies{ get; set; }
        public decimal GetValue() { return Value; }
        public void SetValue(decimal Value) { this.Value = Value; }
        public decimal? getMax(){return max; }
        public void setMax(decimal max){this.max = max;}
        public decimal? getMin(){return min;}
        public void setMin(decimal min){this.min = min;}

		public override string[] Save()
		{
			string[] saveData = new string[Dependancies.Count + 1];
			int n = 0;
			saveData[n++] = ("NUMATTRIB :: " + Name + " :: " + Value + " :: " + max + " :: " + min + " :: " + Group + " :: " + group + " :: " + priority);
			foreach (NumDependency d in Dependancies)
			{
				saveData[n++] = d.Save();
			}
			return saveData;
		}
	}
}
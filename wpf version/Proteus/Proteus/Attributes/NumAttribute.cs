using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Proteus.Attributes
{
	[Serializable]
    public class NumAttribute : CustomAttribute
    {
        private decimal value;
        private decimal? max = null;
        private decimal? min = null;
		public decimal? Max
		{
			get { return max; }
			set { max = value; }
		}
		public decimal? Min
		{
			get { return min; }
			set { min = value; }
		}
		public decimal Value
		{
			get { return value; }
			set { this.value = value; }
		}
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
        public void setMin(decimal min) { this.min = min; }
        public override string ToString()
        {
            return Name;
        }
    }
}
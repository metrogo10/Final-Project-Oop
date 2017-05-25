using FinalProject.Models1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FinalProject
{
    public class NumAttribute : Attribute
    {
        private decimal Value;
        private decimal? max = null;
        private decimal? min = null;
		public bool? Zeroable { get; set; }
		public string Name { get; set; }
        public List<NumDependency> Dependancies{ get; set; }
        public decimal GetValue() { return Value; }
        public void SetValue(decimal Value) { this.Value = Value; }
        public decimal? getMax(){return max; }
        public void setMax(decimal max){this.max = max;}
        public decimal? getMin(){return min;}
        public void setMin(decimal min){this.min = min;}
    }
}
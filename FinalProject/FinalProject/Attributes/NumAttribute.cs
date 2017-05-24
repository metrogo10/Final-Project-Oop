using FinalProject.Models1;
using FinalProject.Models1.FinalProject.Models1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FinalProject
{
    public class NumAttribute
    {
        private decimal Value;
        private decimal? max;
        private decimal? min;
        public List<NumDependency> Dependancies{ get; set; }
        public decimal GetValue() { return Value; }
        public void SetValue(decimal Value) { this.Value = Value; }
        public decimal? getMax(){return max; }
        public void setMax(int max){this.max = max;}
        public decimal? getMin(){return min;}
        public void setMin(int min){this.min = min;}
    }
}
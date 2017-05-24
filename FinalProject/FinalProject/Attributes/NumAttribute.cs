using FinalProject.Models1;
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
        public List<NumDependency> Dependancies { get; set; }
        public decimal GetValue() { return Value; }
        public void SetValue(decimal Value) { this.Value = Value; }
    }
}